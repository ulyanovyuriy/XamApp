using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
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
        }

        public ObservableCollection<MenuPageItem> Items { get; }
    }
}
