using AddonMaster.Core.Data;
using AddonMaster.Core.Data.Entities;
using MahApps.Metro.Controls;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AddonMaster.GUI
{
    public partial class MainWindow : MetroWindow
    {
        private DatabaseManager dbManager;

        public MainWindow(string addonFolderPath)
        {
            InitializeComponent();

            dbManager = new DatabaseManager(addonFolderPath);

            UpdateListBoxOnMainWindow();
        }

        private void imgAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var addonWindow = new AddAddonWindow(this, dbManager);
            addonWindow.Owner = this;
            addonWindow.Show();
        }

        private void imgUpdate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var addon = (sender as Image).DataContext as Addon;

            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            worker.DoWork += (object x, DoWorkEventArgs y) =>
            {
                (x as BackgroundWorker).ReportProgress(0);
                dbManager.RemoveAddon(addon.ID);
                dbManager.AddAddon(addon.DownloadUrl, worker);
            };

            worker.ProgressChanged += (object x, ProgressChangedEventArgs y) => Spinner.Visibility = Visibility.Visible;

            worker.RunWorkerCompleted += (object x, RunWorkerCompletedEventArgs y) =>
            {
                File.Delete(addon.ImagePath);
                UpdateListBoxOnMainWindow();
                Spinner.Visibility = Visibility.Collapsed;
            };

            worker.RunWorkerAsync();
        }

        private void imgRemove_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var addon = (sender as Image).DataContext as Addon;
            var oldImagePath = string.Empty;

            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            worker.DoWork += (object x, DoWorkEventArgs y) => dbManager.RemoveAddon(addon.ID);
            worker.RunWorkerCompleted += (object x, RunWorkerCompletedEventArgs y) => { File.Delete(addon.ImagePath); UpdateListBoxOnMainWindow(); };

            worker.RunWorkerAsync();
        }

        public void UpdateListBoxOnMainWindow()
        {
            lbAddonList.ItemsSource = dbManager.GetAddons().OrderBy(x => x.Name);
            lbAddonList.Items.Refresh();

            if (lbAddonList.Items.Count != 0)
            {
                lblEmptyList.Visibility = Visibility.Collapsed;
            }
            else
            {
                lblEmptyList.Visibility = Visibility.Visible;
            }
        }

        private void imgReport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var reportWindow = new ReportWindow();
            reportWindow.Owner = this;

            reportWindow.Show();
        }

        #region UI Stuff
        private void MetroWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Close();
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
        #endregion
    }
}
