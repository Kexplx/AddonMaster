using AddonMaster.Core.Data;
using AddonMaster.GUI.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Configuration;

namespace AddonMaster.GUI
{
    public partial class MainWindow
    {
        private readonly DatabaseManager _dbManager;

        public MainWindow(string addonFolderPath)
        {
            InitializeComponent();
            _dbManager = new DatabaseManager(addonFolderPath);

            UpdateListBoxOnMainWindow();
        }

        public void CheckForVersionUpdates()
        {
            var currentVersion = ConfigurationManager.AppSettings["version"];

        }

        private void imgAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var addonWindow = new AddAddonWindow(this, _dbManager) {Owner = this};
            addonWindow.Show();
        }

        private void imgUpdate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var addonViewModel = (sender as Image)?.DataContext as AddonViewModel;

            var worker = new BackgroundWorker {WorkerReportsProgress = true};

            worker.DoWork += (x, y) =>
            {
                (x as BackgroundWorker)?.ReportProgress(0);
                if (addonViewModel != null)
                {
                    _dbManager.RemoveAddon(addonViewModel.Addon.Id);
                    _dbManager.AddAddon(addonViewModel.Addon.DownloadUrl, worker);
                }
            };

            worker.ProgressChanged += (x, y) => Spinner.Visibility = Visibility.Visible;

            worker.RunWorkerCompleted += (o, args) =>
            {
                if (addonViewModel != null) File.Delete(addonViewModel.Addon.ImagePath);
                UpdateListBoxOnMainWindow();
                Spinner.Visibility = Visibility.Collapsed;
            };

            worker.RunWorkerAsync();
        }

        private void imgRemove_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var addonViewModel = (sender as Image)?.DataContext as AddonViewModel;

            var worker = new BackgroundWorker {WorkerReportsProgress = true};

            worker.DoWork += (x, y) =>
            {
                if (addonViewModel != null) _dbManager.RemoveAddon(addonViewModel.Addon.Id);
            };
            worker.RunWorkerCompleted += (x, y) =>
            {
                if (addonViewModel != null) File.Delete(addonViewModel.Addon.ImagePath);
                UpdateListBoxOnMainWindow();
            };

            worker.RunWorkerAsync();
        }

        public void UpdateListBoxOnMainWindow()
        {
            var addonViews = new List<AddonViewModel>();

            _dbManager.GetAddons().OrderBy(x => x.Name).ToList().ForEach(x =>
            {
                addonViews.Add(new AddonViewModel { Addon = x });
            });

            LblAddonList.ItemsSource = addonViews;
            LblAddonList.Items.Refresh();
            LblEmptyList.Visibility = LblAddonList.Items.Count != 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        private void imgReport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var reportWindow = new ReportWindow {Owner = this};
            reportWindow.Show();
        }

        #region UI Stuff
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton != MouseButton.Left) return;
            try
            {
                DragMove();
            }
            catch
            {
                // ignored
            }
        }
        #endregion

        private void ImageAwesome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as Image)?.ToolTip as string == "Close")
            {
                Close();
            }
            else if ((sender as Image)?.ToolTip as string == "Minimize")
            {
                WindowState = WindowState.Minimized;
            }
            else if ((sender as Image)?.ToolTip as string == "Help")
            {
                new InfoWindow(this)
                {
                    Owner = this
                }.Show();
            }
        }

        private void ImageAwesome_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Process.Start(_dbManager.AddonFolderPath);
        }
    }
}
