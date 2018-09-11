using Xamarin.Forms;
using XamMaket.Settings;

namespace XamMaket
{
    public partial class App
    {
        private void Init()
        {
            Resources = new ResourceDictionary();

            var style = new Style(typeof(NavigationPage));
            style.Setters.Add(new Setter()
            {
                Property = NavigationPage.BarBackgroundColorProperty,
                Value = ThemeColors.Toolbar,
            });
            style.Setters.Add(new Setter()
            {
                Property = NavigationPage.BarTextColorProperty,
                Value = ThemeColors.White
            });
            Resources.Add(style);
        }
    }
}
