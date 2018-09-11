using System.Collections.Generic;
using Xamarin.Forms;
using XamMaket.ViewModels;
using XamMaket.Views;

namespace XamMaket
{
    public partial class App : Application
    {
        public static App CurrentApp => (App)Application.Current;

        public App()
        {
            Init();

            MainPage = new NavPage(new MainPage(new MainPageViewModel()));
        }

        public T GetResource<T>(string key)
        {
            if (Resources.ContainsKey(key) == false)
                throw new KeyNotFoundException(key);

            return (T)Resources[key];
        }
    }
}
