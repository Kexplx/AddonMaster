using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;

namespace AddonMaster.Core.Data.Entities
{
    public class Addon
    {
        public long ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Patch
        {
            get;
            set;
        }

        public BitmapImage Image
        {
            get
            {
                var img = new BitmapImage();
                using (var stream = File.OpenRead(ImagePath))
                {
                    img.BeginInit();
                    img.CacheOption = BitmapCacheOption.OnLoad;
                    img.StreamSource = stream;
                    img.EndInit();
                }

                return img;
            }
        }

        public string ImagePath
        {
            get;
            set;
        }

        public string DownloadUrl
        {
            get;
            set;
        }

        public List<string> InstalledDirectories
        {
            get;
            set;
        }
    }
}
