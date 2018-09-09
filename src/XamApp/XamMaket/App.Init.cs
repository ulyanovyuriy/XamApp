using Xamarin.Forms;

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
                Value = Color.FromHex("#2196F3")
            });
            style.Setters.Add(new Setter()
            {
                Property = NavigationPage.BarTextColorProperty,
                Value = Color.White
            });
            Resources.Add(style);
        }
    }
}
