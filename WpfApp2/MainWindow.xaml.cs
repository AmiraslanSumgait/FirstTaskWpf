﻿using System;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void BtnLeft_Click(object sender, RoutedEventArgs e)
        {
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            if (sender is Button btn)
            {
                string messageBox = "Button " + btn.Content.ToString() + " is clicked";
                btn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
                MessageBox.Show(messageBox,"Information",MessageBoxButton.OK);
            }
        }
        private void Btn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Button btn)
            {
                Grid.Children.Remove(btn);
                string text = btn.Content.ToString();
                Window.Title += btn.Content.ToString();
            }
        }
    }
}