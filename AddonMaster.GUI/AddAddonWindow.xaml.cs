using MahApps.Metro.Controls;
using System.ComponentModel;
using System.Threading;
using System.Windows.Input;

namespace AddonMaster.GUI
{
    public partial class AddAddonWindow : MetroWindow
    {
        public AddAddonWindow()
        {
            InitializeComponent();
            StartBar();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void StartBar()
        {
            var x = new BackgroundWorker();

            x.WorkerReportsProgress = true;
            x.DoWork += DoWork;
            x.ProgressChanged += ProgressChanged;

            x.RunWorkerAsync();
            x.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) => Close();
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                (sender as BackgroundWorker).ReportProgress(1);
            }
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb1.Value += e.ProgressPercentage;
        }
    }
}
