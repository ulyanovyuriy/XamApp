
using System.Collections.Generic;
using XamMaket.ViewModels;

namespace XamMaket.Views
{
    public partial class MenuPage
    {
        private List<MenuPageItem> _items;

        private IReadOnlyList<MenuPageItem> GetItems() => _items.AsReadOnly();

        private void InitItems()
        {
            _items = new List<MenuPageItem>();

            _items.Add(new MenuPageItem()
            {
                Title = "Главная",
                Icon = "Main.png",
                PageType = typeof(MainPage),
            });
        }
    }
}