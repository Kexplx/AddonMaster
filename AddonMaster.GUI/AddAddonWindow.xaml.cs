using AddonMaster.Core.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace AddonMaster.GUI
{
    public partial class AddAddonWindow
    {
        private readonly MainWindow _mainWindow;
        private readonly DatabaseManager _dbManager;

        private readonly Regex _downloadUrlRegex = new Regex(@"https:\/\/www\.curseforge\.com\/(?i)wow\/addons\/.[^\/]*");

        public AddAddonWindow(MainWindow mainWindow, DatabaseManager dbManager)
        {
            InitializeComponent();

            _dbManager = dbManager;
            _mainWindow = mainWindow;
        }

        private void btnInstall_Click(object sender, RoutedEventArgs e)
        {
            var worker = new BackgroundWorker {WorkerReportsProgress = true};

            worker.DoWork += (x, y) => _dbManager.AddAddon(y.Argument as string, worker);
            worker.ProgressChanged += (x, y) =>
            {
                Pb1.Visibility = Visibility.Visible;
                Spinner.Visibility = Visibility.Visible;
                Pb1.Value += y.ProgressPercentage;
            };
            worker.RunWorkerCompleted += (x, y) => { _mainWindow.UpdateListBoxOnMainWindow(); Close(); };

            worker.RunWorkerAsync(_downloadUrlRegex.Match(TxtUrl.Text).Value);
        }

        private void txtUrl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_downloadUrlRegex.Match(TxtUrl.Text).Value != TxtUrl.Text || TxtUrl.Text == "")
            {
                LblStatus.Visibility = Visibility.Visible;
                BtnInstall.IsEnabled = false;
                BtnInstall.Opacity = 0.6;
            }
            else
            {
                LblStatus.Visibility = Visibility.Collapsed;
                BtnInstall.IsEnabled = true;
                BtnInstall.Opacity = 1;
            }
        }

        #region UI
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Keyboard.ClearFocus();
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
            else if ((sender as Image)?.ToolTip as string == "Help")
            {
                new InfoWindow(this)
                {
                    Owner = this
                }.Show();
            }
        }
        #endregion
    }
}
