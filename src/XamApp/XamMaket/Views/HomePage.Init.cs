
using Xamarin.Forms;

namespace XamMaket.Views
{
    public partial class HomePage
    {
        private void Init()
        {
            Icon = (FileImageSource)FileImageSource.FromFile("Resources/menu.png");

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "1" }
                }
            };
        }
    }
}