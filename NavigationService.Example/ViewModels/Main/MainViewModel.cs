using System;
using System.Windows.Controls;
using System.Windows.Input;
/// <summary>
/// Den här Vymodellen hanterar egenskaper som ska gälla för startsidan (MainView)
/// </summary>
namespace PageNavigation.Example
{
    public class MainViewModel : BaseViewModel
    {
        #region Public properties
        public string Title { get; set; } = "Exempel på navigering";

        /// <summary>
        /// Visar ett command utan parametrar för page 1
        /// </summary>
        public ICommand NavigateToPageCommand { get; set; }

       // Kika in i BaseViewModel. Där finns command för navigering med parameter
        #endregion

        #region Constructor
        public MainViewModel()
        {
            NavigateToPageCommand = new RelayCommand(GotoPage);
        }
        #endregion

        private void GotoPage()
        {
            Page page = new Page1();
            NavigationService.Navigate(page);
        }

        protected override void GotoPage(object parameter)
        {
            var selectedPage = (ApplicationPage)parameter;

            // Om vi tänker oss lägga till unika indata till sidan måste 
            // vi skapa en ny specifik vymodell

            // Börjar med att skapa en spelare
            var player = new Cpu { Fullname = "R2D2" };
            var model = new Page2ViewModel(player); //Helt ok, eftersom Cpu implementerar IFullname
            Page page = NavigateToPageHelper.GetPage(selectedPage, model);

           
            
            NavigationService.Navigate(page);
        }



    }
}
