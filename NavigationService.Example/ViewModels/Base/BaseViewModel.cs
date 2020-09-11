using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Navigation;

namespace Navigering.Example
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected static NavigationService NavigationService { get; } = (Application.Current.MainWindow as MainWindow).mainFrame.NavigationService;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
