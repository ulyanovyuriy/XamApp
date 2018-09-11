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
                    PageType = typeof(HomePage),
                    Type = MenuPageItemType.Home,
                },
            };
        }

        public ObservableCollection<MenuPageItem> Items { get; }
    }
}
