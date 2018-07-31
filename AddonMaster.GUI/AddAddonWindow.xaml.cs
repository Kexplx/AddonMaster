using AddonMaster.Core.Data;
using MahApps.Metro.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace AddonMaster.GUI
{
    public partial class AddAddonWindow : MetroWindow
    {
        private MainWindow mainWindow;
        private DatabaseManager dbManager;

        private Regex downloadUrlRegex = new Regex(@"https:\/\/www\.curseforge\.com\/(?i)wow\/addons\/[^\/]*");

        public AddAddonWindow(MainWindow mainWindow, DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.mainWindow = mainWindow;
            txtUrl.Focus();
        }

        private void btnInstall_Click(object sender, RoutedEventArgs e)
        {
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += (object x, DoWorkEventArgs y) => dbManager.AddAddon(y.Argument as string, worker);
            worker.ProgressChanged += (object x, ProgressChangedEventArgs y) => { pb1.Visibility = Visibility.Visible; spinner.Visibility = Visibility.Visible; pb1.Value += y.ProgressPercentage; };
            worker.RunWorkerCompleted += (object x, RunWorkerCompletedEventArgs y) => { mainWindow.UpdateListBoxOnMainWindow(); Close(); };

            worker.RunWorkerAsync(downloadUrlRegex.Match(txtUrl.Text).Value);
        }

        private void txtUrl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (downloadUrlRegex.Match(txtUrl.Text).Value != txtUrl.Text)
            {
                lblStatus.Visibility = Visibility.Visible;
                btnInstall.IsEnabled = false;
                btnInstall.Opacity = 0.6;
            }
            else
            {
                lblStatus.Visibility = Visibility.Collapsed;
                btnInstall.IsEnabled = true;
                btnInstall.Opacity = 0.9;
            }
        }

        #region UI

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void ImageAwesome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as Image).ToolTip as string == "Close")
            {
                Close();
            }
            else if ((sender as Image).ToolTip as string == "Minimize")
            {
                WindowState = WindowState.Minimized;
            }
        }
        #endregion
    }
}
