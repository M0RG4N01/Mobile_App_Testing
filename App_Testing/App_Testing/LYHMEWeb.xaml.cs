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
	public partial class LYHMEWeb : ContentPage
	{
		public LYHMEWeb ()
		{
			InitializeComponent ();

            //Label header = new Label
            //{
            //    Text = "WebView",
            //    FontSize = 50,
            //    FontAttributes = FontAttributes.Bold,
            //    HorizontalOptions = LayoutOptions.Center
            //};

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://www.lyhmehosting.com/"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            Title = "LYHMEHosting";
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