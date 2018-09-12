using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamMaket.ViewModels;

namespace XamMaket.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Init();
        }

        public MenuPageViewModel ViewModel => BindingContext as MenuPageViewModel;
    }
}