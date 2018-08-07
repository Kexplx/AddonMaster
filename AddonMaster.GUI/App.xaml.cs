using AddonMaster.Core.Data;

namespace AddonMaster.GUI
{
    public partial class App
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
