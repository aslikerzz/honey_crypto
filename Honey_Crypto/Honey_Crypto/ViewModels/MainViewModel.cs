using CommunityToolkit.Mvvm.ComponentModel;

namespace Honey_Crypto.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
