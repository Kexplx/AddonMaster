using AddonMaster.Core.Data;
using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
    }
}
