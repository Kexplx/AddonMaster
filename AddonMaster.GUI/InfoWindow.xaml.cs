using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AddonMaster.GUI
{
    public partial class InfoWindow
    {
        public InfoWindow(MetroWindow window)
        {
            InitializeComponent();
            switch (window)
            {
                case MainWindow _:
                    txtMainWindow.Visibility = Visibility.Visible;
                    break;

                case SetupWindow _:
                    txtSetupWindow.Visibility = Visibility.Visible;
                    break;

                case AddAddonWindow _:
                    txtAddAddonWindow.Visibility = Visibility.Visible;
                    break;

                case ReportWindow _:
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
            if ((sender as Image)?.ToolTip as string == "Close")
            {
                Close();
            }
            else if ((sender as Image)?.ToolTip as string == "Minimize")
            {
                WindowState = WindowState.Minimized;
            }
        }
        #endregion
    }
}
