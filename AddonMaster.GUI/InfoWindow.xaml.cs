using MahApps.Metro.Controls;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AddonMaster.GUI
{
    public partial class InfoWindow : MetroWindow
    {
        public InfoWindow(MetroWindow window)
        {
            InitializeComponent();
            switch (window)
            {
                case MainWindow x:
                    txtMainWindow.Visibility = Visibility.Visible;
                    break;

                case SetupWindow x:
                    txtSetupWindow.Visibility = Visibility.Visible;
                    break;

                case AddAddonWindow x:
                    txtAddAddonWindow.Visibility = Visibility.Visible;
                    break;

                case ReportWindow x:
                    txtReportWindow.Visibility = Visibility.Visible;
                    break;
            }
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
    }
}
