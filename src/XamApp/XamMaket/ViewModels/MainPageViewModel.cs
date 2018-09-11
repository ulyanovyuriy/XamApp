using System;
using System.Collections.Generic;
using System.Text;

namespace XamMaket.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        public MainPageViewModel()
        {
            Menu = new MenuPageViewModel();
        }

        public MenuPageViewModel Menu { get; }
    }
}
