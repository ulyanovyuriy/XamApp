using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamMaket.ViewModels;

namespace XamMaket.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync(MenuPageItemType itemType);
    }
}
