using System.Collections.Generic;

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
