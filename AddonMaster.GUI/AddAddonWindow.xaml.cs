using AddonMaster.Core.Data;
using AddonMaster.Core.Data.Entities;
using MahApps.Metro.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Navigation;

namespace AddonMaster.GUI
{
    public partial class AddAddonWindow : MetroWindow
    {
        private MainWindow mainWindow;
        private DatabaseManager dbManager;

        private Addon addonForUpdate;

        private Regex downloadUrlRegex = new Regex(@"https:\/\/www\.curseforge\.com\/wow\/addons\/[^\/]*");

        public AddAddonWindow(MainWindow mainWindow, DatabaseManager dbManager, Addon addon = null)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.mainWindow = mainWindow;

            //update of addon, setText contains the url
            if (addon != null)
            {
                btnInstall.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                txtUrl.Text = addon.DownloadUrl;
                addonForUpdate = addon;
            }
        }

        private void btnInstall_Click(object sender, RoutedEventArgs e)
        {
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += (object x, DoWorkEventArgs y) =>
            {
                if (addonForUpdate != null)
                {
                    dbManager.RemoveAddon(addonForUpdate.ID);
                };
                dbManager.AddAddon(y.Argument as string, worker);
            };
            worker.ProgressChanged += (object x, ProgressChangedEventArgs y) => { pb1.Visibility = Visibility.Visible; spinner.Visibility = Visibility.Visible; pb1.Value += y.ProgressPercentage; };
            worker.RunWorkerCompleted += (object x, RunWorkerCompletedEventArgs y) => { mainWindow.CallbackWhenDownloadFinished(); Close(); };

            worker.RunWorkerAsync(downloadUrlRegex.Match(txtUrl.Text).Value);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void txtUrl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!downloadUrlRegex.IsMatch(txtUrl.Text))
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

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
