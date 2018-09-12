
using System.IO;
using Xamarin.Forms;
using XamMaket.Settings;
using XamMaket.ViewModels;

namespace XamMaket.Views
{
    public partial class MenuPage
    {
        private void Init()
        {
            Title = " ";
            BackgroundColor = ThemeColors.Toolbar;
            Padding = new Thickness(0, 40, 0, 0);

            var listView = new ListView()
            {
                BackgroundColor = ThemeColors.MenuBackground,
                SeparatorVisibility = SeparatorVisibility.None,
                ItemTemplate = new DataTemplate(() =>
                {
                    return new ViewCell()
                    {
                        View = new MenuItemView()
                    };
                }),
            };

            listView.SetBinding(ListView.ItemsSourceProperty, nameof(ViewModel.Items));
            listView.ItemSelected += ListView_ItemSelected;
            Content = new StackLayout
            {
                Children =
                {
                    listView
                },
            };
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel.ItemSelectedCommand.Execute(e.SelectedItem);
        }
    }
}