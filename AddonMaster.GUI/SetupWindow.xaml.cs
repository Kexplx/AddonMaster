using AddonMaster.Core.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WinForms = System.Windows.Forms;

namespace AddonMaster.GUI
{
    public partial class SetupWindow
    {
        public SetupWindow()
        {
            InitializeComponent();
        }

        private void TxtPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Directory.Exists((sender as TextBox)?.Text))
            {
                try
                {
                    LblStatus.Visibility = Visibility.Visible;
                    BtnContinue.IsEnabled = false;
                    BtnContinue.Opacity = 0.6;
                }
                catch
                {
                    // ignored
                }
            }
            else
            {
                LblStatus.Visibility = Visibility.Collapsed;
                BtnContinue.IsEnabled = true;
                BtnContinue.Opacity = 1;
            }
        }

        private void btnOpenDirectoryDialogue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            using (var dialog = new WinForms.FolderBrowserDialog())
            {
                dialog.ShowDialog();
                var result = dialog.SelectedPath;
                TxtAddonFolderPath.Text = result;
            }
        }

        private void btnContinue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var configHandler = new ConfigHandler();
            configHandler.CreateOrUpdateConfig(TxtAddonFolderPath.Text);

            new MainWindow(TxtAddonFolderPath.Text).Show();
            Close();
        }

        #region UI
        private void MetroWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    DragMove();
                }
            }
            catch
            {
                // ignored
            }
        }

        private void ImageAwesome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as Image)?.ToolTip as string == "Close")
            {
                Close();
            }
            else if((sender as Image)?.ToolTip as string == "Minimize")
            {
                WindowState = WindowState.Minimized;
            }
            else if((sender as Image)?.ToolTip as string == "Help")
            {
                new InfoWindow(this)
                {
                    Owner = this
                }.Show();
            }
        }
        #endregion
    }
}
