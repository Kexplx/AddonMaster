using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddAddonWindow.xaml
    /// </summary>
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
