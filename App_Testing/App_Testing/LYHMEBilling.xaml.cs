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
    public partial class LYHMEBilling : ContentPage
    {
        public LYHMEBilling()
        {
            InitializeComponent();

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://billing.lyhmehosting.com/clientarea.php"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            Title = "LYHMEBilling";
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