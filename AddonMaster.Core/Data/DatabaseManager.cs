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
        private Regex addonDownloadRessourceRegex = new Regex(@"\/wow\/addons\/.*\/download\/\d*\/file");
        private static Regex addonNameRegex = new Regex("<meta property=\"og:title\" content=\"(.*)\"");
        private Regex addonImageRegex = new Regex("<meta property=\"og:image\" content=(.*[\\.png|\\.jpg])\"");
        private Regex addonDescriptionRegex = new Regex("<meta name=\"description\" content=\"(.*)\"");
        private Regex addonPatchRegex = new Regex("Game Version: (.*)<");

        private XmlSerializer serializer;
        private string dbPath;
        private string dbParentPath;
        private string addonFolderPath;

        public DatabaseManager(string addonFolderPath)
        {
            serializer = new XmlSerializer(typeof(List<Addon>));
            dbPath = addonFolderPath + @"\AddonMaster\addonMasterDB.xml";
            dbParentPath = addonFolderPath + @"\AddonMaster\";
            this.addonFolderPath = addonFolderPath;

            if (!File.Exists(dbPath))
            {
                Directory.CreateDirectory(dbParentPath);
                using (File.Create(dbPath))
                { }
            }
        }

        public List<Addon> GetAddons()
        {
            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                try
                {
                    return (List<Addon>)serializer.Deserialize(stream);
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
                return (List<Addon>)serializer.Deserialize(s);
            }
            catch
            {
                return new List<Addon>();
            }
        }

        public void AddAddon(string url, BackgroundWorker backGroundWorker)
        {
            Addon addon = new Addon
            {
                ID = new Random().Next(1, 999999999),
                DownloadUrl = url,
                InstalledDirectories = new List<string>()
            };
            backGroundWorker.ReportProgress(5);

            using (WebClient client = new WebClient())
            {
                var htmlSource = client.DownloadString(url + @"/download");
                var guid = Guid.NewGuid();

                backGroundWorker.ReportProgress(20);
                //Addon itself
                client.DownloadFile("https://www.curseforge.com" + addonDownloadRessourceRegex.Match(htmlSource).Value, addonFolderPath + @"\" + guid + ".zip");
                using (var file = ZipFile.OpenRead(addonFolderPath + @"\" + guid + ".zip"))
                {
                    file.Entries
                                .Select(x => x.FullName.Split('/')
                                                                    .First())
                                                                    .Distinct()
                                                                               .ToList()
                                                                               .ForEach(z =>
                                                                               {
                                                                                   addon.InstalledDirectories.Add(addonFolderPath + @"\" + z);

                                                                                   if (Directory.Exists(addonFolderPath + @"\" + z))
                                                                                   {
                                                                                       Directory.Delete(addonFolderPath + @"\" + z, true);
                                                                                   }
                                                                               });

                    ZipFile.ExtractToDirectory(addonFolderPath + @"\" + guid + ".zip", addonFolderPath);
                }

                File.Delete(addonFolderPath + @"\" + guid + ".zip");

                backGroundWorker.ReportProgress(40);
                //Name
                addon.Name = addonNameRegex.Match(htmlSource).Groups[1].Value;

                backGroundWorker.ReportProgress(10);
                //Image
                client.DownloadFile(addonImageRegex.Match(htmlSource).Groups[1].Value.Trim(new char[] { '\\', '\"' }), dbParentPath + guid + ".png");
                addon.ImagePath = dbParentPath + @"\" + guid + ".png";

                backGroundWorker.ReportProgress(10);
                //Description
                addon.Description = addonDescriptionRegex.Match(htmlSource.Split(new string[] { "Meta Properties" }, StringSplitOptions.None)[1]).Groups[1].Value.Trim(new char[] { '\\', '\"' });

                backGroundWorker.ReportProgress(10);
                //Patch
                addon.Patch = addonPatchRegex.Match(htmlSource).Groups[1].Value.Trim(new char[] { '\\', '\"' });
            }

            List<Addon> currentAddons;

            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                currentAddons = GetAddons(stream);
                currentAddons.RemoveAll(x => x.Name == addon.Name); //in case addon is downloaded twice ;)

                currentAddons.Add(addon);
            }

            File.WriteAllText(dbPath, string.Empty);
            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                serializer.Serialize(stream, currentAddons);
            }

            backGroundWorker.ReportProgress(5);
        }

        public void RemoveAddon(long id)
        {
            List<Addon> listToWrite;
            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                var currentList = GetAddons(stream);
                var currentAddon = currentList.Where(x => x.ID == id).First();
                currentList.RemoveAll(x => x.ID == id);
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

            File.WriteAllText(dbPath, string.Empty);

            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                serializer.Serialize(stream, listToWrite);
            }
        }
    }
}
