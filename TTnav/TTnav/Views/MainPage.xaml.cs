using CommunityToolkit.Maui.Views;
using System.Diagnostics;

namespace TTnav.Views
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var adPopup = new Adpage();
            if (Application.Current != null && Application.Current.MainPage != null)
            {
                await Application.Current.MainPage.ShowPopupAsync(adPopup);
            }
            else
            {
#if DEBUG
                Debug.Assert(false);
#endif
            }
        }
    }

}
