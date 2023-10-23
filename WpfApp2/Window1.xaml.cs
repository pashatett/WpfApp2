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

using System.Data;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Otvet.Text = string.Empty;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Last.Text = string.Empty;
            Otvet.Text = string.Empty;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 1;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 2;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 3;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 4;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 5;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 6;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 7;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 8;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 9;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Otvet.Text += 0;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Otvet.Text += "/";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Otvet.Text += "*";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Otvet.Text += "-";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Otvet.Text += "+";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            Otvet.Text += ".";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Otvet.Text = Otvet.Text.Substring(0, Otvet.Text.Length - 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Last.Text = Otvet.Text;
            Otvet.Text = new DataTable().Compute(Otvet.Text, null).ToString();
        }
    }
}
