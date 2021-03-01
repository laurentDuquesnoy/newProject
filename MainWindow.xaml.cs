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

namespace newProject
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
        public int Counter = 0;
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            lblCounter.Content = Counter;
        }   
        
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Counter++;
            lblCounter.Content = Counter;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Counter--;
            lblCounter.Content = Counter;
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "Hello World!";
        }
    }
}
