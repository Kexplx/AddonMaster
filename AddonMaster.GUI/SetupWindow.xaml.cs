using AddonMaster.Core.Data;
using MahApps.Metro.Controls;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WinForms = System.Windows.Forms;

namespace AddonMaster.GUI
{
    public partial class SetupWindow : MetroWindow
    {
        public SetupWindow()
        {
            InitializeComponent();
        }

        private void TxtPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Directory.Exists((sender as TextBox).Text))
            {
                try
                {
                    lblStatus.Visibility = Visibility.Visible;
                    btnContinue.IsEnabled = false;
                    btnContinue.Opacity = 0.6;
                }
                catch { }
            }
            else
            {
                lblStatus.Visibility = Visibility.Collapsed;
                btnContinue.IsEnabled = true;
                btnContinue.Opacity = 0.9;
            }
        }

        private void btnOpenDirectoryDialogue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            using (var dialog = new WinForms.FolderBrowserDialog())
            {
                dialog.ShowDialog();
                var result = dialog.SelectedPath;
                txtAddonFolderPath.Text = result;
            }
        }

        private void btnContinue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var configHandler = new ConfigHandler();
            configHandler.CreateOrUpdateConfig(txtAddonFolderPath.Text);

            new MainWindow(txtAddonFolderPath.Text).Show();
            Close();
        }

        #region UI
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as MenuItem).Header.ToString() == "Close")
            {
                Close();
            }
            else
            {
                WindowState = WindowState.Minimized;
            }
        }

        private void MetroWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    DragMove();
                }
            }
            catch { }
        }

        private void MetroWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Close();
            }
        }

        #endregion
    }
}
