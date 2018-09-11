using System;

namespace XamMaket.ViewModels
{
    public class MenuPageItem : ViewModel
    {
        public string Title { get; set; }

        public string Icon { get; set; }

        public MenuPageItemType Type { get; set; }
    }
}
