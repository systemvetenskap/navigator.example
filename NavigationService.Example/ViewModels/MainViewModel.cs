using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace NavigationService.Example
{
    class MainViewModel : BaseViewModel
    {
        public ICommand NavigationCommand { get; set; }

        public MainViewModel()
        {
           NavigationCommand = new RelayCommand(GotoPage);
        }

        public void GotoPage()
        {
            var page = new Page1();
            navigationService.Navigate(page);
        }
    }
}
