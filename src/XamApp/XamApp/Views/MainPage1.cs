
using Xamarin.Forms;

namespace XamApp.Views
{
    public class MainPage1 : ContentPage
    {
        public MainPage1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}