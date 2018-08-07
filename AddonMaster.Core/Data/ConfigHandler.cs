using System.IO;

namespace AddonMaster.Core.Data
{
    /// <summary>
    /// The Config saves the folder's path where the addons will be saved in, it's located in the /bin/config.txt
    /// </summary>
    public class ConfigHandler
    {
        private readonly string _configPath = "config.xml";

        public void CreateOrUpdateConfig(string addonFolder)
        {
            using (var stream = File.Open(_configPath, FileMode.OpenOrCreate))
            {
                var writer = new StreamWriter(stream);
                writer.WriteLine(addonFolder);
                writer.Close();
            }
        }

        public string GetAddonFolderNameOutOfConfig()
        {
            using (var stream = File.Open(_configPath, FileMode.Open))
            {
                var reader = new StreamReader(stream);
                return reader.ReadLine();
            }
        }

        public bool DoesConfigExist()
        {
            return File.Exists(_configPath);
        }
    }
}
