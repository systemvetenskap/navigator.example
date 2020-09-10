using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace NavigationService.Example
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected static System.Windows.Navigation.NavigationService NavigationService { get; } = (Application.Current.MainWindow as MainWindow).mainFrame.NavigationService;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
