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
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

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
    }
}
