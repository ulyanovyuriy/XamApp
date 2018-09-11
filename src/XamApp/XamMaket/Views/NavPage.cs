using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamMaket.Views
{
    public partial class NavPage : NavigationPage
    {
        public NavPage() : base()
        {
            Init();
        }

        public NavPage(Page root) : base(root)
        {
            Init();
        }
    }
}