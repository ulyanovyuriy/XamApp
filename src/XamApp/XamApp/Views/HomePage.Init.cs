
using Xamarin.Forms;

namespace XamApp.Views
{
    public partial class HomePage : MasterDetailPage
    {
        private void InitializeComponent()
        {
            MasterBehavior = MasterBehavior.Popover;

            Master = new MenuPage();

            Detail = new NavigationPage(new MainPage1());
        }
    }
}