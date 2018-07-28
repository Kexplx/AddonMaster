using AddonMaster.Core.Data;
using AddonMaster.Core.Data.Entities;
using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace AddonMaster.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private DatabaseManager dbManager;

        public MainWindow(string addonFolderPath)
        {
            InitializeComponent();

            dbManager = new DatabaseManager(addonFolderPath);
            lbAddonList.ItemsSource = dbManager.GetAddons();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void imgAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new AddAddonWindow(this, dbManager).Show();
        }

        public void CallbackWhenDownloadFinished()
        {
            lbAddonList.ItemsSource = dbManager.GetAddons();
            lbAddonList.Items.Refresh();
        }

        private void imgRemove_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void imgUpdate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var addon = (sender as Image).DataContext as Addon;

            new AddAddonWindow(this, dbManager, addon).Show();
        }

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
    }
}
