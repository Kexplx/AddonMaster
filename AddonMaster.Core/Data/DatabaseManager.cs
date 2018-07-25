using AddonMaster.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace AddonMaster.Core.Data
{
    /// <summary>
    /// Handles the creation of the DB, also enables writes, reades and deletes, db is the file 
    /// </summary>
    public class DatabaseManager
    {
        private Regex downloadFileRegex = new Regex(@"\/wow\/addons\/.*\/download\/\d*\/file");
        private static Regex nameRegex = new Regex("<meta property=\"og:title\" content=\"(.*)\"");
        private Regex imageRegex = new Regex("<meta property=\"og:image\" content=(.*[\\.png|\\.jpg])\"");
        private Regex DescriptonRegex = new Regex("<meta name=\"description\" content=\"(.*)\"");
        private Regex patchRegex = new Regex("Game Version: (.*)<");

        private XmlSerializer serializer;
        private string dbPath;
        private string dbParentPath;
        private string addonFolderPath;

        public DatabaseManager(string addonFolderPath)
        {
            serializer = new XmlSerializer(typeof(List<Addon>));
            dbPath = addonFolderPath + @"\AddonMaster\addonDb.txt";
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
                DownloadUrl = url
            };

            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                var htmlSource = client.DownloadString(url + @"/download");
                var guid = Guid.NewGuid();

                backGroundWorker.ReportProgress(14);
                //Addon itself
                client.DownloadFile("https://www.curseforge.com" + downloadFileRegex.Match(htmlSource).Value, addonFolderPath + guid + ".zip");
                System.IO.Compression.ZipFile.ExtractToDirectory(addonFolderPath + guid + ".zip", addonFolderPath);
                File.Delete(addonFolderPath + guid + ".zip");

                backGroundWorker.ReportProgress(14);
                //Name
                addon.Name = nameRegex.Match(htmlSource).Groups[1].Value;

                backGroundWorker.ReportProgress(14);
                //Image
                client.DownloadFile(imageRegex.Match(htmlSource).Groups[1].Value.Trim(new char[] { '\\', '\"' }), dbParentPath + guid + ".png");
                addon.ImagePath = dbParentPath + @"\" + guid + ".png";

                backGroundWorker.ReportProgress(14);
                //Description
                addon.Description = DescriptonRegex.Match(htmlSource.Split(new string[] { "Meta Properties" }, StringSplitOptions.None)[1]).Groups[1].Value.Trim(new char[] { '\\', '\"' });

                backGroundWorker.ReportProgress(14);
                //Patch
                addon.Patch = patchRegex.Match(htmlSource).Groups[1].Value.Trim(new char[] { '\\', '\"' });

                backGroundWorker.ReportProgress(14);
            }

            List<Addon> currentAddons;

            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                currentAddons = GetAddons(stream);
                currentAddons.Add(addon);
            }

            File.WriteAllText(dbPath, string.Empty);
            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                serializer.Serialize(stream, currentAddons);
            }

            backGroundWorker.ReportProgress(16);
        }

        public void RemoveAddon(int id)
        {
            using (var stream = File.Open(dbPath, FileMode.Open))
            {
                var currentList = GetAddons();
                var currentAddon = currentList.Where(x => x.ID == id).First();

                File.Delete(currentAddon.ImagePath);
                currentList.RemoveAll(x => x.ID == id);

                foreach (var dir in Directory.GetDirectories(addonFolderPath))
                {
                    if (dir.ToUpperInvariant().Contains(currentAddon.Name.ToUpperInvariant()))
                    {
                        Directory.Delete(dir, true);
                    }
                }

                serializer.Serialize(stream, currentList);
            }
        }
    }
}
