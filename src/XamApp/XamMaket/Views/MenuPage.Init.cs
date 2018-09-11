
using System.IO;
using Xamarin.Forms;
using XamMaket.Settings;

namespace XamMaket.Views
{
    public partial class MenuPage
    {
        private void Init()
        {
            Title = " ";
            BackgroundColor = ThemeColors.Toolbar;

            Content = new StackLayout
            {
                Children =
                {
                    new ListView()
                    {
                        BackgroundColor = ThemeColors.MenuBackground,
                        SeparatorVisibility = SeparatorVisibility.None,
                        ItemsSource = ViewModel.Items,
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new ViewCell()
                            {
                                View = new MenuItemView()
                            };
                        }),
                    }
                }

            };
        }
    }
}