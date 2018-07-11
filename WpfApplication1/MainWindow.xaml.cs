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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Diagnostics;
using System.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public int number = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"The description is: {this.Result.Text}");
            if (number < 8)
            {
                number += 1;

                if (number == 1)
                    this.Result.Text = "1/8: The crystal's power has stirred.";
                if (number == 2)
                    this.Result.Text = "2/8: The crystal glows faintly.";
                if (number == 3)
                    this.Result.Text = "3/8: The crystal is dimly lit.";
                if (number == 4)
                    this.Result.Text = "4/8: The crystal emits a gentle light.";
                if (number == 5)
                    this.Result.Text = "5/8: The crystal dazzles radiantly!";
                if (number == 6)
                    this.Result.Text = "6/8: The crystal is sparkling!";
                if (number == 7)
                    this.Result.Text = "7/8: The crystal shines bright!";
                if (number == 8)
                    this.Result.Text = "8/8: The crystal divinely shimmers. *(GO!)*";
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"The description is: {this.Result.Text}");
            number = 0;
            this.Result.Text = "0/8: The crystal's power is dormant.";
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            this.Topmost = true;
        }

        private void Window_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            this.Topmost = true;

            this.Activate();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            /*this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;

            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;

            

            this.Top = 0;

            this.Left = 0;*/

            this.Topmost = true;
        }


    }
}
