
using System.IO;
using Xamarin.Forms;

namespace XamMaket.Views
{
    public partial class MenuPage
    {
        private void Init()
        {
            Padding = new Thickness(0, 40, 0, 0);
            Title = "Приложение";

            Content = new StackLayout
            {
                Children =
                {
                    new ListView()
                    {
                        ItemsSource = GetItems(),
                        ItemTemplate = new DataTemplate(() =>
                        {
                            var grid = new Grid() { Padding = new Thickness(5,10) };
                            //grid.ColumnDefinitions.Add(new ColumnDefinition(){ });
                            return new ViewCell() { View = grid };
                        }),
                    }
                }

            };
        }
    }
}