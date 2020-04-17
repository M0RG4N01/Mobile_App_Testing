using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Testing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LYHMESupport : ContentPage
    {
        public LYHMESupport()
        {
            InitializeComponent();

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://billing.lyhmehosting.com/submitticket.php?step=2&deptid=12"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            Title = "LYHMESupport";
            Content = new StackLayout
            {
                Children =
                {
                    webView
                }
            };
        }
    }
}
