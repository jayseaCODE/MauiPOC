using WorkingWithMaps.ViewModels;
using Microsoft.Maui; using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Maps;

namespace MauiPOC.View
{
    public partial class PinItemsSourcePage : ContentPage
    {
        public PinItemsSourcePage()
        {
            InitializeComponent();
            BindingContext = new PinItemsSourcePageViewModel();
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(39.8283459, -98.5794797), Distance.FromMiles(1500)));
        }

        void OnMapClicked(object sender, MapClickedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"MapClick: {e.Position.Latitude}, {e.Position.Longitude}");
        }
    }
}
