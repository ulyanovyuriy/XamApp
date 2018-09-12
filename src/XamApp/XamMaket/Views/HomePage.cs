using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamMaket.ViewModels;

namespace XamMaket.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            Init();
        }

        public HomePageViewModel ViewModel => BindingContext as HomePageViewModel;
    }
}