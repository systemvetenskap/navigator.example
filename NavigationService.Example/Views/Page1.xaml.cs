using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NavigationService.Example.Models;

namespace NavigationService.Example
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void GotoPage2_Click(object sender, RoutedEventArgs e)
        {
            // med specifik vymodell i konstruktorn
            IFullname player = new Person() { Firstname = "Erik", Lastname = "Öberg" };
            NavigationService.Navigate(new Page2(new Page2ViewModel(player)));
        }
    }
}
