using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PageNavigation.Example
{
    public class BaseViewModel : INotifyPropertyChanged
    {
       
        #region Properties

        /// <summary>
        /// Egenskap som hanterar all sidnavigering
        /// </summary>
        protected static NavigationService NavigationService { get; } = (Application.Current.MainWindow as MainWindow).mainFrame.NavigationService;
        
        /// <summary>
        /// Detta kommando används för sidnavigering när man har en parameter som styr valet av sida
        /// </summary>
        public ICommand NavigateToPageByParameterCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Methods
        /// <summary>
        /// Metod som skapar en Page utifrån en indataparameter
        /// </summary>
        /// <param name="parameter">Vald sida av typen <see cref="ApplicationPage"/></param>

        protected virtual void GotoPage(object parameter)
        {
            var selectedPage = (ApplicationPage)parameter;
            // För att slippa skapa sidor i Vymodellen använder jag mig istället av en hjälpklass 
            Page page = NavigateToPageHelper.GetPage(selectedPage);
            NavigationService.Navigate(page);
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
        #region Constructor
        public BaseViewModel()
        {
            NavigateToPageByParameterCommand = new RelayParameterizedCommand(parameter => GotoPage(parameter));
        }
        #endregion
    }
}

