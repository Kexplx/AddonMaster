using AddonMaster.Core.Data;
using MahApps.Metro.Controls;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace AddonMaster.GUI
{
    public partial class AddAddonWindow : MetroWindow
    {
        private MainWindow mainWindow;
        private DatabaseManager dbManager;

        private Regex downloadUrlRegex = new Regex(@"https:\/\/www\.curseforge\.com\/wow\/addons\/[^\/]*");

        public AddAddonWindow(MainWindow mainWindow, DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.mainWindow = mainWindow;
        }

        private void btnInstall_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += (object x, DoWorkEventArgs y) => dbManager.AddAddon(y.Argument as string, worker);
            worker.ProgressChanged += (object x, ProgressChangedEventArgs y) => pb1.Value += y.ProgressPercentage;
            worker.RunWorkerCompleted += (object x, RunWorkerCompletedEventArgs y) => { mainWindow.CallbackWhenDownloadFinished(); Close(); };

            worker.RunWorkerAsync(downloadUrlRegex.Match(txtUrl.Text).Value);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void txtUrl_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!downloadUrlRegex.IsMatch(txtUrl.Text))
            {
                txtValidUrl.Visibility = System.Windows.Visibility.Visible;
                btnInstall.IsEnabled = false;
            }
            else
            {
                txtValidUrl.Visibility = System.Windows.Visibility.Collapsed;
                btnInstall.IsEnabled = true;
            }
        }
    }
}
