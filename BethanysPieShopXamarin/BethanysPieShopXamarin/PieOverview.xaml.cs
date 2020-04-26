using BethanysPieShopXamarin.Model;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieOverview : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public PieOverview()
        {
            InitializeComponent();

        }

        private async void PiesListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPie = e.SelectedItem as Pie;
        }
    }
}
