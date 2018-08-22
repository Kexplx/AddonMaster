using AddonMaster.Core.Data.Entities;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AddonMaster.GUI.ViewModels
{
    /// <summary>
    /// View Model of an Addon for the UI to use
    /// </summary>
    public class AddonViewModel
    {
        public Addon Addon
        {
            get;
            set;
        }

        public BitmapImage Image
        {
            get
            {
                var img = new BitmapImage();
                using (var stream = File.OpenRead(Addon.ImagePath))
                {
                    img.BeginInit();
                    img.CacheOption = BitmapCacheOption.OnLoad;
                    img.StreamSource = stream;
                    img.EndInit();
                }

                return img;
            }
        }

        public Visibility UpdateCogVisibility
        {
            get;
            set;
        } = Visibility.Collapsed;
    }
}
