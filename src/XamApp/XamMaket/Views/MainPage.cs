using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamMaket.Services;
using XamMaket.ViewModels;

namespace XamMaket.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            Init();
        }

        public MainPageViewModel ViewModel => BindingContext as MainPageViewModel;
    }
}