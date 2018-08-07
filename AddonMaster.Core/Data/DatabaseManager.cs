using AddonMaster.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace AddonMaster.Core.Data
{
    /// <summary>
    /// Handles the creation of the DB's xml file, provides methods for reading, writing addons
    /// </summary>
    public class DatabaseManager
    {
        private readonly Regex _addonDownloadRessourceRegex = new Regex(@"\/(?i)wow\/addons\/.*\/download\/\d*\/file");
        private readonly Regex _addonNameRegex = new Regex("<meta property=\"og:title\" content=\"(.*)\"");
        private readonly Regex _addonImageRegex = new Regex("<meta property=\"og:image\" content=(?i)(.*[\\.png|\\.jpg])\"");
        private readonly Regex _addonDescriptionRegex = new Regex("<meta name=\"description\" content=\"(.*)\"");
        private readonly Regex _addonPatchRegex = new Regex("Game Version: (.*)<");

        private readonly XmlSerializer _serializer;
        private readonly string _dbPath;
        private readonly string _dbParentPath;
        private readonly string _addonFolderPath;

        public DatabaseManager(string addonFolderPath)
        {
            _serializer = new XmlSerializer(typeof(List<Addon>));
            _dbPath = addonFolderPath + @"\AddonMaster\addonMasterDB.xml";
            _dbParentPath = addonFolderPath + @"\AddonMaster\";
            _addonFolderPath = addonFolderPath;

            if (!File.Exists(_dbPath))
            {
                if (!Directory.Exists(_dbParentPath))
                {
                    Directory.CreateDirectory(_dbParentPath);
                }
                using (File.Create(_dbPath))
                { }
            }
        }

        public List<Addon> GetAddons()
        {
            using (var stream = File.Open(_dbPath, FileMode.Open))
            {
                try
                {
                    return (List<Addon>)_serializer.Deserialize(stream);
                }
                catch
                {
                    return new List<Addon>();
                }
            }
        }

        public List<Addon> GetAddons(FileStream s)
        {
            try
            {
                return (List<Addon>)_serializer.Deserialize(s);
            }
            catch
            {
                return new List<Addon>();
            }
        }

        public void AddAddon(string url, BackgroundWorker backGroundWorker)
        {
            using (var client = new WebClient())
            {
                var addon = new Addon
                {
                    Id = new Random().Next(1, 999999999),
                    DownloadUrl = url,
                    InstalledDirectories = new List<string>()
                };
                backGroundWorker.ReportProgress(5);
                var htmlSource = client.DownloadString(url + @"/download");

                var guid = Guid.NewGuid();

                backGroundWorker.ReportProgress(20);
                //Addon itself
                client.DownloadFile("https://www.curseforge.com" + _addonDownloadRessourceRegex.Match(htmlSource).Value, _addonFolderPath + @"\" + guid + ".zip");
                using (var file = ZipFile.OpenRead(_addonFolderPath + @"\" + guid + ".zip"))
                {
                    file.Entries
                                .Select(x => x.FullName.Split('/')
                                                                    .First())
                                                                    .Distinct()
                                                                               .ToList()
                                                                               .ForEach(z =>
                                                                               {
                                                                                   addon.InstalledDirectories.Add(_addonFolderPath + @"\" + z);

                                                                                   if (Directory.Exists(_addonFolderPath + @"\" + z))
                                                                                   {
                                                                                       Directory.Delete(_addonFolderPath + @"\" + z, true);
                                                                                   }
                                                                               });

                    ZipFile.ExtractToDirectory(_addonFolderPath + @"\" + guid + ".zip", _addonFolderPath);
                }

                File.Delete(_addonFolderPath + @"\" + guid + ".zip");

                backGroundWorker.ReportProgress(50);
                //Name
                addon.Name = _addonNameRegex.Match(htmlSource).Groups[1].Value;

                backGroundWorker.ReportProgress(5);
                //Image
                client.DownloadFile(_addonImageRegex.Match(htmlSource).Groups[1].Value.Trim('\\', '\"'), _dbParentPath + guid + ".png");
                addon.ImagePath = _dbParentPath + @"\" + guid + ".png";

                backGroundWorker.ReportProgress(19);
                //Description
                addon.Description = _addonDescriptionRegex
                    .Match(htmlSource.Split(new[] { "Meta Properties" }, StringSplitOptions.None)[1]).Groups[1].Value
                    .Trim('\\', '\"');

                //Patch
                addon.Patch = _addonPatchRegex.Match(htmlSource).Groups[1].Value.Trim('\\', '\"');

                //Write addon to xml file
                List<Addon> currentAddons;

                using (var stream = File.Open(_dbPath, FileMode.Open))
                {
                    currentAddons = GetAddons(stream);
                    try
                    {
                        File.Delete(currentAddons.First(x => x.Name == addon.Name).ImagePath);
                        currentAddons.RemoveAll(x => x.Name == addon.Name); //in case addon is downloaded twice
                    }
                    catch
                    {
                        // ignored
                    }

                    currentAddons.Add(addon);
                }

                File.WriteAllText(_dbPath, string.Empty);
                using (var stream = File.Open(_dbPath, FileMode.Open))
                {
                    _serializer.Serialize(stream, currentAddons);
                }

                backGroundWorker.ReportProgress(1);
            }
        }

        public void RemoveAddon(long id)
        {
            List<Addon> listToWrite;
            using (var stream = File.Open(_dbPath, FileMode.Open))
            {
                var currentList = GetAddons(stream);
                var currentAddon = currentList.First(x => x.Id == id);
                currentList.RemoveAll(x => x.Id == id);
                listToWrite = currentList;

                currentAddon.InstalledDirectories
                                                .ForEach(z =>
                                                {
                                                    if (Directory.Exists(z))
                                                    {
                                                        Directory.Delete(z, true);
                                                    }
                                                });
            }

            File.WriteAllText(_dbPath, string.Empty);

            using (var stream = File.Open(_dbPath, FileMode.Open))
            {
                _serializer.Serialize(stream, listToWrite);
            }
        }
    }
}
