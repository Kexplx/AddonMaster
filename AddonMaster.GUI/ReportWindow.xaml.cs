using MahApps.Metro.Controls;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AddonMaster.GUI
{
    public partial class ReportWindow : MetroWindow
    {
        public ReportWindow()
        {
            InitializeComponent();

            checkboxBug.IsChecked = true;
        }

        private void imgSend_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var worker = new BackgroundWorker { WorkerReportsProgress = true };

            worker.DoWork += (object x, DoWorkEventArgs y) =>
            {
                (x as BackgroundWorker).ReportProgress(0);
                var client = new SmtpClient
                {
                    Port = 25,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("addonmaster404@gmail.com", "fpo120**.sad21ioiosa")
                };

                var mail = new MailMessage("addonmaster404@gmail.com", "oscar.rosner@web.de");

                if ((y.Argument as Tuple<bool?, string>).Item1 ?? false)
                {
                    mail.Subject = "AddonMaster: Bug Report";
                }
                else
                {
                    mail.Subject = "AddonMaster: General Feedback";
                }

                mail.Body = (y.Argument as Tuple<bool?, string>).Item2;
                client.Send(mail);
            };

            worker.ProgressChanged += (object x, ProgressChangedEventArgs y) => spinner.Visibility = Visibility.Visible;
            worker.RunWorkerCompleted += (object x, RunWorkerCompletedEventArgs y) => { spinner.Visibility = Visibility.Collapsed; txtContent.Text = string.Empty; Keyboard.ClearFocus(); };

            worker.RunWorkerAsync(Tuple.Create(checkboxBug.IsChecked, txtContent.Text));
        }

        private void checkboxFeedback_Checked(object sender, RoutedEventArgs e)
        {
            checkboxBug.IsChecked = false;
        }

        private void checkboxBug_Checked(object sender, RoutedEventArgs e)
        {
            checkboxFeedback.IsChecked = false;
        }

        private void txtContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                imgSend.Opacity = 1;
                imgSend.IsEnabled = true;
            }
            else
            {
                imgSend.Opacity = 0.8;
                imgSend.IsEnabled = false;
            }
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
            catch { }
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
            else if ((sender as Image).ToolTip as string == "Help")
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
