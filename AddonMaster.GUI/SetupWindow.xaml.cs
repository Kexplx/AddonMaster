using AddonMaster.Core.Data;
using MahApps.Metro.Controls;
using System.IO;
using System.Windows;
using System.Windows.Input;
using WinForms = System.Windows.Forms;

namespace AddonMaster.GUI
{
    public partial class SetupWindow : MetroWindow
    {
        private string addonPath;

        public SetupWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lets the user select the folder for the addon installation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenFolderDialogue_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new WinForms.FolderBrowserDialog())
            {
                dialog.ShowDialog();
                var result = dialog.SelectedPath;

                if (Directory.Exists(result))
                {
                    addonPath = result;
                    TxtPath.Text = addonPath;

                    LblStatus.Visibility = Visibility.Collapsed;
                }
                else
                {
                    BtnContinue.IsEnabled = false;
                }
            }
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            if (addonPath != null & Directory.Exists(addonPath))
            {
                var configHandler = new ConfigHandler();
                configHandler.CreateOrUpdateConfig(addonPath);

                new MainWindow(addonPath).Show();
                Close();
            }
            else
            {
                LblStatus.Visibility = Visibility.Visible;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
