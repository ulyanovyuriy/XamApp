
using Xamarin.Forms;

namespace XamMaket.Views
{
    public partial class HomePage
    {
        private void Init()
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