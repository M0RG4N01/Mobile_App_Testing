using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Testing
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            //// Build the page.

            //Title = "LYHME, Inc.";

            NavigationPage.SetTitleIcon(this, "https://cdn.discordapp.com/attachments/368118450322669569/576895964724461608/LYHMEHosting-Black.png");
            var titleView = new Image { Source = ImageSource.FromUri(new Uri("https://cdn.discordapp.com/attachments/368118450322669569/576895964724461608/LYHMEHosting-Black.png")) };
            NavigationPage.SetTitleView(this, titleView);
            Title = "LYHME, Inc";

            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        new StackLayout
            //        {                       
            //            Children =
            //            {
            //                button1,
            //                button2,
            //                button3,
            //                button4,
            //                button5,
            //                button6,
            //            }
            //        }
            //    }
            //};

            //Grid grid = new Grid
            //{
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    Margin = new Thickness(10),
            //    RowDefinitions =
            //    {
            //        new RowDefinition { Height = GridLength.Auto },
            //        new RowDefinition { Height = GridLength.Auto },
            //        new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
            //        new RowDefinition { Height = new GridLength (100, GridUnitType.Absolute) }
            //    },
            //    ColumnDefinitions =
            //    {
            //        new ColumnDefinition { Width = GridLength.Auto },
            //        new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
            //        new ColumnDefinition { Width = new GridLength (100, GridUnitType.Absolute) }
            //    }
            //};

            //grid.Children.Add(new Label
            //{              
            //    Text = "100x100",
            //    TextColor = Color.Aqua,  
            //    BackgroundColor = Color.Red,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center
            //}, 2, 3);

            //grid.Children.Add(new Image
            //{
            //    Aspect = Aspect.AspectFit, Source = "https://lyhmehosting.com/img/logos/invoice.png",
            //}, 0, 1, 0, 1);

            //// Build the page.

            //Content = grid;

        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void OnOrderClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LYHMEWeb());
        }

        async void OnBillingClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LYHMEBilling());
        }

        async void OnSupportClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LYHMESupport());
        }

        async void OnPanelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LYHMEPanel());
        }

        void OnDiscordClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://discordapp.com/invite/Bh9RZTZ"));
            //Rivets.AppLinks.Navigator.Navigate("https://discordapp.com/invite/Bh9RZTZ");
            return;

        }

        async void OnStatusClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LYHMEWeb());
        }

        async void OnCallHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CallHistoryPage());
        }

    }
}
