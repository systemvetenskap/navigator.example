using System.Windows.Controls;
/// <summary>
/// hjälpmetoder för att generera rätt sida
/// </summary>
namespace PageNavigation.Example
{
    public static class NavigateToPageHelper
    {
        /// <summary>
        /// Returnerar en Page utifrån vald sida
        /// </summary>
        /// <param name="page">Indata av  typen <see cref="ApplicationPage"/></param>
        /// <param name="model">Specifik vymodell som ska laddas, default = null <</param>
        /// <returns></returns>
        public static Page GetPage(ApplicationPage page, BaseViewModel model = null)
        {
            return page switch
            {
                ApplicationPage.SelectGameMode => new Page1(),
                ApplicationPage.PlayGame => model != null ? new Page2(model) : new Page2(),
                _ => null,
            };
        }
    }
}
