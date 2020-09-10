using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NavigationService.Example
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
