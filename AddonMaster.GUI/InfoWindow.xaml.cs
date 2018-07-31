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
using System.Windows.Shapes;

namespace AddonMaster.GUI
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : MetroWindow
    {
        public InfoWindow()
        {

            InitializeComponent();

            //switch (window)
            //{
            //    case MainWindow x:

            //        break;
            //}
        }

        #region UI
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

        private void txtMainWindow_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
