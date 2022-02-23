using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  //suorittaa designin
        }

        // Numeronappuloiden funktiot

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "0";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            CheckNumber();
            Screen.Text += "9";
        }

        // Laskunappuloiden funktiot

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text += " + ";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text += " - ";
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text += " / ";
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text += " * ";
        }

        //Muut nappulat

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            List<string> screenList = Screen.Text.Split(' ').ToList();

            while(screenList.Count > 1)
            {
                if (screenList[1] == "+" && screenList.Count >= 3)
                {
                    screenList[0] = PlusCalculation(screenList[0], screenList[2]);
                }
                else if(screenList[1] == "-" && screenList.Count >= 3)
                {
                    screenList[0] = MinusCalculation(screenList[0], screenList[2]);
                }
                else if (screenList[1] == "/" && screenList.Count >= 3)
                {
                    screenList[0] = DivisionCalculation(screenList[0], screenList[2]);
                }
                else if (screenList[1] == "*" && screenList.Count >= 3)
                {
                    screenList[0] = TimesCalculation(screenList[0], screenList[2]);
                }

                screenList.RemoveRange(1, 2);
            }
            Screen.Text = screenList[0];
            
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = "0";
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
        }

        //lasku funktiot

        private string PlusCalculation(string firstValue, string secondValue)
        {
            return (int.Parse(firstValue) + int.Parse(secondValue)).ToString();
        }

        private string MinusCalculation(string v1, string v2)
        {
            return (int.Parse(v1) - int.Parse(v2)).ToString();
        }

        private string TimesCalculation(string v1, string v2)
        {
            return (int.Parse(v1) * int.Parse(v2)).ToString();
        }

        private string DivisionCalculation(string v1, string v2)
        {
            return (int.Parse(v1) / int.Parse(v2)).ToString();
        }

        private void CheckNumber()
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "";
            }
        }
    }
}
