namespace TTnav.Views;

public partial class SplashPage : ContentPage
{
	public SplashPage()
	{
		InitializeComponent();
        BindingContext = new TTnav.ViewModels.SplashViewModel();
    }
}