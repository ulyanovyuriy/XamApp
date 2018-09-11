using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamMaket.Views
{
    public partial class MainPage
    {
        private void Init()
        {
            MasterBehavior = MasterBehavior.Popover;

            Master = new MenuPage(ViewModel.Menu);

            Detail = new DetailPage();
        }
    }
}