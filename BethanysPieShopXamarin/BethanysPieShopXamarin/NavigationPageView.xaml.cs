using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void HomePageButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.HomePageView());
        }

        private async void PieOverviewButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.PieOverviewView());
        }

        private async void BasketButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.BasketView());
        }

        private async void ContactUsButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.ContactusView());
        }
    }
}