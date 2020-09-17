using PageNavigation.Example.Models;

namespace PageNavigation.Example
{
    public class Page2ViewModel : BaseViewModel
    {
        public string Text { get; set; } = "Dummytext";

        public Page2ViewModel() { }
       
        public Page2ViewModel(IFullname player):base()
        {
            // Modellen Person har fullname som genereras från för- och efternamn
            // Modellen CPU implementerar samma interface, men med en helt annan struktur. Båda ska fungera
            // i vår modell blir det ändå en player
            Text = player.Fullname;
        }
       
    }
}
