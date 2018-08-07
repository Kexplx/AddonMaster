using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AddonMaster.GUI
{
    public partial class ReportWindow
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        private void imgSend_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var worker = new BackgroundWorker { WorkerReportsProgress = true };

            worker.DoWork += (x, y) =>
            {
                (x as BackgroundWorker)?.ReportProgress(0);
                var client = new SmtpClient
                {
                    Port = 25,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("addonmaster404@gmail.com", "fpo120**.sad21ioiosa")
                };

                var mail = new MailMessage("addonmaster404@gmail.com", "oscar.rosner@web.de");

                if (((Tuple<bool?, string>) y.Argument).Item1 ?? false)
                {
                    mail.Subject = "AddonMaster: Bug Report";
                }
                else
                {
                    mail.Subject = "AddonMaster: General Feedback";
                }

                mail.Body = ((Tuple<bool?, string>) y.Argument).Item2 ?? throw new InvalidOperationException();
                client.Send(mail);
            };

            worker.ProgressChanged += (x, y) => Spinner.Visibility = Visibility.Visible;
            worker.RunWorkerCompleted += (x, y) =>
            {
                Spinner.Visibility = Visibility.Collapsed;
                TxtContent.Text = string.Empty;
                Keyboard.ClearFocus();
            };

            worker.RunWorkerAsync(Tuple.Create(CheckboxBug.IsChecked, TxtContent.Text));
        }
        #region UI
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    Keyboard.ClearFocus();
                    DragMove();
                }
            }
            catch
            {
                // ignored
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
