using AddonMaster.Core.Data;
using AddonMaster.Core.Data.Entities;
using AddonMaster.GUI.ViewModels;
using MahApps.Metro.Controls;
using System.Collections.Generic;
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
            var addon = (sender as Image).DataContext as AddonViewModel;
            var oldImagePath = string.Empty;

            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            worker.DoWork += (object x, DoWorkEventArgs y) => dbManager.RemoveAddon(addon.Addon.ID);
            worker.RunWorkerCompleted += (object x, RunWorkerCompletedEventArgs y) => { File.Delete(addon.Addon.ImagePath); UpdateListBoxOnMainWindow(); };

            worker.RunWorkerAsync();
        }

        public void UpdateListBoxOnMainWindow()
        {
            var addonViews = new List<AddonViewModel>();

            dbManager.GetAddons().OrderBy(x => x.Name).ToList().ForEach(x =>
            {
                addonViews.Add(new AddonViewModel { Addon = x });
            });

            lbAddonList.ItemsSource = addonViews;

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
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                try
                {
                    DragMove();
                }
                catch { }
            }
        }
        #endregion

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
            else if ((sender as Image).ToolTip as string == "Help")
            {
                new InfoWindow(this)
                {
                    Owner = this
                }.Show();
            }
        }
    }
}
