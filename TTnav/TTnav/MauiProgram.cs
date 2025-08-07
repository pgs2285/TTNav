using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TTnav.Views;


namespace TTnav
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<SplashPage>();
            builder.Services.AddSingleton<TTnav.ViewModels.SplashViewModel>();



            return builder.Build();
        }
    }
}
