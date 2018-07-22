using AddonMaster.Core.Data;
using System.Windows;

namespace AddonMaster.GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var configHandler = new ConfigHandler();

            if (configHandler.DoesConfigExist())
            {
                new MainWindow(configHandler.GetAddonFolderNameOutOfConfig()).Show();
            }
            else
            {
                new SetupWindow().Show();
            }
        }
    }
}
