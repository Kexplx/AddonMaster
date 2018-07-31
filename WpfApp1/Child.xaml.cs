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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Child.xaml
    /// </summary>
    public partial class Child : Window
    {
        public Child(Window window)
        {
            InitializeComponent();

            if (window is Father1)
            {
                lbl1.Background = Brushes.Green;
            }
            else
            {
                lbl1.Background = Brushes.Red;
            }
        }
    }
}
