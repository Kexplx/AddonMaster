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

        private void BtnOpenFolderDialogue_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new WinForms.FolderBrowserDialog())
            {
                dialog.ShowDialog();
                var result = dialog.SelectedPath;
                TxtPath.Text = result;
            }
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            var configHandler = new ConfigHandler();
            configHandler.CreateOrUpdateConfig(TxtPath.Text);

            new MainWindow(TxtPath.Text).Show();
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void TxtPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Directory.Exists((sender as TextBox).Text))
            {
                try
                {
                    LblStatus.Visibility = Visibility.Visible;
                    BtnContinue.IsEnabled = false;
                }
                catch { }
            }
            else
            {
                LblStatus.Visibility = Visibility.Collapsed;
                BtnContinue.IsEnabled = true;
            }
        }
    }
}
