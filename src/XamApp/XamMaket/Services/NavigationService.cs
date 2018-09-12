using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamMaket.ViewModels;
using XamMaket.Views;

namespace XamMaket.Services
{
    public class NavigationService : INavigationService
    {
        #region INavigationService Support

        async Task INavigationService.NavigateToAsync(MenuPageItemType itemType)
        {
            await NavigateToAsync(itemType);
        }

        #endregion

        public async Task NavigateToAsync(MenuPageItemType itemType)
        {
            var page = GetOrCreatePage(itemType);

            var mdp = App.CurrentApp.MainPage;
            var current = mdp.Detail;
            if (current != page)
            {
                mdp.Detail = page;
            }
            if (mdp.IsPresented)
                mdp.IsPresented = false;
        }

        private Dictionary<MenuPageItemType, Page> _pages = new Dictionary<MenuPageItemType, Page>();
        private Page GetOrCreatePage(MenuPageItemType itemType)
        {
            Page p;
            if (_pages.TryGetValue(itemType, out p) == false)
            {
                p = CreatePage(itemType);
                _pages[itemType] = p;
            }
            return p;
        }

        private Page CreatePage(MenuPageItemType itemType)
        {
            if (itemType == MenuPageItemType.Home)
                return new HomePage() { BindingContext = new HomePageViewModel() };
            else if (itemType == MenuPageItemType.Cards)
                return new CardsPage() { BindingContext = new CardsPageViewModel() };

            else throw new NotSupportedException(nameof(itemType) + ": " + itemType);
        }


    }
}
