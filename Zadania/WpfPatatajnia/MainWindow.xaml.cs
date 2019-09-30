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

namespace WpfPatatajnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            Counter = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = Counter++;
            button.Background = new SolidColorBrush(Colors.Blue);
        }
    }
}
