
using Xamarin.Forms;
using XamMaket.Settings;

namespace XamMaket.Views
{
    public partial class MenuItemView : ContentView
    {
        private void Init()
        {
            var grid = new Grid()
            {
                Margin = new Thickness(0, 0, 12, 0),
                ColumnDefinitions = new ColumnDefinitionCollection()
                {
                    new ColumnDefinition(){ Width = 30},
                    new ColumnDefinition(){ Width = GridLength.Star}
                },
                RowDefinitions = new RowDefinitionCollection()
                {
                    new RowDefinition(){ Height = 48}
                }
            };

            var image = new Image()
            {
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            image.SetBinding(Image.SourceProperty, nameof(ViewModel.Icon));

            grid.Children.Add(image, 0, 0);

            var label = new Label()
            {
                FontSize = 14,
                TextColor = ThemeColors.White,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(12, 0),
            };
            label.SetBinding(Label.TextProperty, nameof(ViewModel.Title));

            grid.Children.Add(label, 1, 0);

            Content = grid;
        }
    }
}