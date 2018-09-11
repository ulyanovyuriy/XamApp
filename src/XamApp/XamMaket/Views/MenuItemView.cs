
using Xamarin.Forms;
using XamMaket.ViewModels;

namespace XamMaket.Views
{
    public partial class MenuItemView : ContentView
    {
        public MenuItemView()
        {
            Init();
        }

        public MenuPageItem ViewModel => BindingContext as MenuPageItem;
    }
}