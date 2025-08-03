using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;

namespace BuggyTasks.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetLocation(); 
    }

    async Task GetLocation()
    {
        try
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            if (location != null)
            {
                Console.WriteLine($"Lat: {location.Latitude}, Long: {location.Longitude}");
                LocationLabel.Text = $"Lat: {location.Latitude}, Long: {location.Longitude}";
            }
            else
            {
                LocationLabel.Text = "Could not get last known location";
            }
        }
        catch (Exception ex)
        {
            LocationLabel.Text = ex.Message;
        }
    }
}