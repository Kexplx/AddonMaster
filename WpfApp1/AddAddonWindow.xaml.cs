using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Input;
using System.Windows.Media;

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

            var x = 0;
            while (x <= 7)
            {
                (sender as BackgroundWorker).ReportProgress(x++);
                Thread.Sleep(1000);
            }
        }


        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var directory = new Dictionary<int, SolidColorBrush>
                {
                    {0, new SolidColorBrush(Colors.Red)},
                    {1, new SolidColorBrush(Colors.LightSkyBlue)},
                    {2, new SolidColorBrush(Colors.Orange)},
                    {3, new SolidColorBrush(Colors.DarkOrange)},
                    {4, new SolidColorBrush(Colors.Blue)},
                    {5, new SolidColorBrush(Colors.SlateGray)},
                    {6, new SolidColorBrush(Colors.DarkSalmon)},
                };

            cogs.Foreground = directory[e.ProgressPercentage];
        }

        private void ImageAwesome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StartBar();
        }

        private void MetroWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                Close();
        }

    }
}
