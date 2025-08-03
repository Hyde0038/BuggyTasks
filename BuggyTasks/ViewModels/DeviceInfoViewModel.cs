using CommunityToolkit.Mvvm.ComponentModel;

namespace BuggyTasks.ViewModels
{
    public partial class DeviceInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        string model;

        [ObservableProperty]
        string platform;

        public DeviceInfoViewModel()
        {
            Model = Microsoft.Maui.Devices.DeviceInfo.Model;
            Platform = Microsoft.Maui.Devices.DeviceInfo.Platform.ToString();
        }
    }
}