using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamMaket.Services;
using XamMaket.Views;

namespace XamMaket.ViewModels
{
    public class MenuPageViewModel : ViewModel
    {
        public MenuPageViewModel()
        {
            Items = new ObservableCollection<MenuPageItem>()
            {
                new MenuPageItem()
                {
                    Title = "Домашняя",
                    Icon = "Images/home.png",
                    Type = MenuPageItemType.Home,
                },
                new MenuPageItem()
                {
                    Title = "Карты",
                    Icon = "Images/credit-card.png",
                    Type = MenuPageItemType.Cards,
                }
            };

            ItemSelectedCommand = new Command<MenuPageItem>(OnItemSelected);
        }

        public ObservableCollection<MenuPageItem> Items { get; }

        public ICommand ItemSelectedCommand { get; }

        private async void OnItemSelected(MenuPageItem item)
        {
            await ServiceExecutor.Default
                .ExecuteAsync<INavigationService>(nav => nav.NavigateToAsync(item.Type));
        }
    }
}
