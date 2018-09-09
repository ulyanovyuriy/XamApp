using Xamarin.Forms;
using XamMaket.Views;

namespace XamMaket
{
    public partial class App : Application
    {
        public App()
        {
            Init();

            MainPage = new HomePage();
        }
    }
}
