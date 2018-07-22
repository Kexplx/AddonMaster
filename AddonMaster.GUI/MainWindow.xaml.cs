using AddonMaster.Core.Data;
using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace AddonMaster.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(string addonFolderPath)
        {
            InitializeComponent();

            var dbManager = new DatabaseManager(addonFolderPath);
            lbAddonList.ItemsSource = dbManager.GetAddons();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            //var todo = button.DataContext as TodoItem;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        #region UI
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri(@"C:\Users\Oscar\source\repos\AddonMaster\WpfApp1\Resources\Add_16x.png"));
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri(@"C:\Users\Oscar\source\repos\AddonMaster\WpfApp1\Resources\Add_grey_16x.png"));
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
        #endregion
    }
}
