using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactView : ContentPage
    {
        public ContactView()
        {
            InitializeComponent();
        }

        private async void SendMessageButton_OnClicked(object sender, EventArgs e)
        {
           await  this.DisplayAlert("Success", "Message sent successfully", "Done");

        }

        private void ContactMeSwitch_OnToggled(object sender, ToggledEventArgs e)
        {
            //handle the switch change here
        }
    }
}
