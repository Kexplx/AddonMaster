using AddonMaster.Core.Data;
using System.Windows;

namespace AddonMaster.GUI
{
    public partial class App : Application
    {
        public App()
        {

            new InfoWindow().Show();
            //var configHandler = new ConfigHandler();

            //if (configHandler.DoesConfigExist())
            //{
            //    new MainWindow(configHandler.GetAddonFolderNameOutOfConfig()).Show();
            //}
            //else
            //{
            //    new SetupWindow().Show();
            //}
        }
    }
}
