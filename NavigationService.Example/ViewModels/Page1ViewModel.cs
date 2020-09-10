using System.Windows.Input;
using System.Windows.Media;
using NavigationService.Example.Models;

namespace NavigationService.Example
{
    public class Page1ViewModel : BaseViewModel
    {
        public ICommand NavigationCommand { get; set; }
        public string Text { get; set; } = "Dummytext";

        public Page1ViewModel()
        {
            NavigationCommand = new RelayCommand(GotoPage);
        }

        public void GotoPage()
        {
            var page = new Page1();
            navigationService.Navigate(page);
        }

        public Page1ViewModel(IFullname player)
        {
            // Modellen Person har fullname som genereras från för- och efternamn
            // Modellen CPU implementerar samma interface, men med en helt annan struktur. Båda ska fungera
            // i vår modell blir det ändå en player
            Text = player.Fullname;
        }
    }
}
