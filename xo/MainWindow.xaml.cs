using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace xo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool kot;
        bool hodil;
        string whois;
        string mers; 
        public void changezk()
        {
            if (kot == true)
            {
                kot = false;
            }
            else
            {
                kot = true;
            }
        }
        public void who()
        {
            if (kot == true)
            {
                whois = "человек";
            }
            else
            {
                whois = "машина";
            }
        }
        public void setznak()
        {
            if (kot == true)
            {
                mers = "X";
            }
            else
            {
                mers = "0";
            }
        }
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public void minus()
        {
            if (numbers.Count > 0)
            {
                Random rnd = new Random();
                int indexToRemove = rnd.Next(0, numbers.Count);
                int numberToRemove = numbers[indexToRemove];
                numbers.RemoveAt(indexToRemove);
                if (numberToRemove == 1)
                {
                    setznak();
                    changezk();
                    b1.Content = mers;
                    b1.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 2)
                {
                    setznak();
                    changezk();
                    b2.Content = mers;
                    b2.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 3)
                {
                    setznak();
                    changezk();
                    b3.Content = mers;
                    b3.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 4)
                {
                    setznak();
                    changezk();
                    b4.Content = mers;
                    b4.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 5)
                {
                    setznak();
                    changezk();
                    b5.Content = mers;
                    b5.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 6)
                {
                    setznak();
                    changezk();
                    b6.Content = mers;
                    b6.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 7)
                {
                    setznak();
                    changezk();
                    b7.Content = mers;
                    b7.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 8)
                {
                    setznak();
                    changezk();
                    b8.Content = mers;
                    b8.IsEnabled = false;
                    win();
                    who();
                }
                if (numberToRemove == 9)
                {
                    setznak();
                    changezk();
                    b9.Content = mers;
                    b9.IsEnabled = false;
                    win();
                    who();
                }
            }
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b1.Content = mers;
            b1.IsEnabled = false;
            win();
            numbers.Remove(1);
            who();
            Thread.Sleep(1000);
            minus();
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b2.Content = mers;
            b2.IsEnabled = false;
            win();
            numbers.Remove(2);
            who();
            Thread.Sleep(1000);
            minus();
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b3.Content = mers;
            b3.IsEnabled = false;
            win();
            numbers.Remove(3);
            who();
            Thread.Sleep(1000);
            minus();
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b4.Content = mers;
            b4.IsEnabled = false;
            win();
            numbers.Remove(4);
            who();
            Thread.Sleep(1000);
            minus();

        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b5.Content = mers;
            b5.IsEnabled = false;
            win();
            numbers.Remove(5);
            who();
            Thread.Sleep(1000);
            minus();
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b6.Content = mers;
            b6.IsEnabled = false;
            win();
            numbers.Remove(6);
            who();
            Thread.Sleep(1000);
            minus();

        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b7.Content = mers;
            b7.IsEnabled = false;
            win();
            numbers.Remove(7);
            who();
            Thread.Sleep(1000);
            minus();
        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b8.Content = mers;
            b8.IsEnabled = false;
            win();
            numbers.Remove(8);
            who();
            Thread.Sleep(1000);
            minus();
        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            setznak();
            changezk();
            b9.Content = mers;
            b9.IsEnabled= false;
            win();
            numbers.Remove(9);
            who();
            Thread.Sleep(1000);
            minus();

        }
        private void restart_Click(object sender, RoutedEventArgs e)
        {
            numbers.Clear();
            b1.IsEnabled = true;
            b1.Content = "";
            b2.IsEnabled = true;
            b2.Content = "";
            b3.IsEnabled = true;
            b3.Content = "";
            b4.IsEnabled = true;
            b4.Content = "";
            b5.IsEnabled = true;
            b5.Content = "";
            b6.IsEnabled = true;
            b6.Content = "";
            b7.IsEnabled = true;
            b7.Content = "";
            b8.IsEnabled = true;
            b8.Content = "";
            b9.IsEnabled = true;
            b9.Content = "";
            nol.Text = "играйте";
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
        }
        public void block()
        {
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            b6.IsEnabled = false;
            b7.IsEnabled = false;
            b8.IsEnabled = false;
            b9.IsEnabled = false;
        }
        private void win()
        {
            if ((b1.Content == b2.Content) && (b2.Content == b3.Content) && (!b1.IsEnabled && !b2.IsEnabled && !b3.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
            if ((b4.Content == b5.Content) && (b5.Content == b6.Content) && (!b4.IsEnabled && !b5.IsEnabled && !b6.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
            if ((b7.Content == b8.Content) && (b8.Content == b9.Content) && (!b7.IsEnabled && !b8.IsEnabled && !b9.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
            if ((b1.Content == b5.Content) && (b5.Content == b9.Content) && (!b1.IsEnabled && !b5.IsEnabled && !b9.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
            if ((b3.Content == b5.Content) && (b5.Content == b7.Content) && (!b3.IsEnabled && !b5.IsEnabled && !b7.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
            if ((b1.Content == b4.Content) && (b4.Content == b7.Content) && (!b1.IsEnabled && !b4.IsEnabled && !b7.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
            if ((b8.Content == b2.Content) && (b2.Content == b5.Content) && (!b2.IsEnabled && !b5.IsEnabled && !b8.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
            if ((b3.Content == b6.Content) && (b6.Content == b9.Content) && (!b3.IsEnabled && !b6.IsEnabled && !b9.IsEnabled))
            {
                nol.Text = "Победил " + whois;
                block();
            }
        }
        private void start_Click(object sender, RoutedEventArgs e)
        {
            b5.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;
            b7.Visibility = Visibility.Visible;
            b8.Visibility = Visibility.Visible;
            b9.Visibility = Visibility.Visible;
            b1.Visibility = Visibility.Visible;
            b6.Visibility= Visibility.Visible;  
            nol.Visibility = Visibility.Visible;
            b1.IsEnabled = true;
            b1.Content = "";
            b2.IsEnabled = true;
            b2.Content = "";
            b3.IsEnabled = true;
            b3.Content = "";
            b4.IsEnabled = true;
            b4.Content = "";
            b5.IsEnabled = true;
            b5.Content = "";
            b6.IsEnabled = true;
            b6.Content = "";
            b7.IsEnabled = true;
            b7.Content = "";
            b8.IsEnabled = true;
            b8.Content = "";
            b9.IsEnabled = true;
            b9.Content = "";
            nol.Text = "играйте";
            restart.IsEnabled= true;
            restart.Visibility= Visibility.Visible;
            start.IsEnabled = false;
            start.Visibility= Visibility.Hidden;
            whois = "человек";
        }
    }
}
