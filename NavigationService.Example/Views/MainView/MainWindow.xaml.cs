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

namespace NavigationService.Example
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

        private void GotoPage1_Click(object sender, RoutedEventArgs e)
        {
            // använd navigation service
            mainFrame.Navigate(new Page1());
            // På sida ett hittar du ett anrop med en spelare
        }

        private void GotoPage2_Click(object sender, RoutedEventArgs e)
        {
            // utan indataparameter
            mainFrame.Navigate(new Page2());
        }

        private void GotoPage3_Click(object sender, RoutedEventArgs e)
        {
            var player = new Cpu { Fullname = "R2D2" };
            mainFrame.Navigate(new Page2(new Page2ViewModel(player)));
        }
    }
}
