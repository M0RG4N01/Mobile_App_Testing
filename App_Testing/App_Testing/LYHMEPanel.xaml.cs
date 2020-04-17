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
	public partial class LYHMEPanel : ContentPage
	{
		public LYHMEPanel ()
		{
			InitializeComponent ();

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://dev.lyhmepanel.com/"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            Title = "LYHMEPanel";
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