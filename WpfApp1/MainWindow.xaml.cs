using AddonMaster.Core.Data.Entities;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var list = new List<Addon>();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {

                    list.Add(new Addon { Description = "Something something description", Name = "Bartender", ImagePath = @"C:\Users\Oscar\source\repos\AddonMaster\WpfApp1\Resources\Add_grey_16x.png", Patch = "8.0.1" });
                }
                else
                {
                    list.Add(new Addon { Description = "Something something description", Name = "Bartender", ImagePath = @"C:\Users\Oscar\source\repos\AddonMaster\WpfApp1\Resources\UpdatedScript_16x.png", Patch = "8.0.1" });
                }
            }

            lbAddonList.ItemsSource = list;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
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

        private void imgUpdate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //get download url from addon, open AddAddonWindow with the url in consturctor
        }

        private void imgRemove_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void imgAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void MetroWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                Close();
        }
    }
}
