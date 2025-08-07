// ViewModels/SplashViewModel.cs
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TTnav.ViewModels;

public partial class SplashViewModel : ObservableObject
{
    private readonly INavigation _navigation;

    public SplashViewModel()
    {
        // INavigation은 Shell로 이동 시엔 생략 가능
        LoadSplashAsync();
    }

    private async void LoadSplashAsync()
    {
        await Task.Delay(2000); // 2초 대기
        await Shell.Current.GoToAsync("//MainPage"); 
    }
}
