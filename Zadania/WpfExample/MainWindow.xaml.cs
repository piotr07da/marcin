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

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter;

        public MainWindow()
        {
            InitializeComponent();

            _counter = 10;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            _counter += 10;

            btn1.Content = "Klikkkk " + _counter;
            btn1.BorderBrush = new SolidColorBrush(_counter % 20 == 0 ? Colors.Red : Colors.Blue);

            textBlock1.Text = _counter.ToString();
        }
    }
}
