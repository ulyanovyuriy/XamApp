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
            Title = "Главная";
            Icon = (FileImageSource)FileImageSource.FromFile("menu.png");

            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "2" },
                    //new Image(){ Source = FileImageSource.FromResource("XamMaket.menu.png")},
                }
            };
        }
    }
}