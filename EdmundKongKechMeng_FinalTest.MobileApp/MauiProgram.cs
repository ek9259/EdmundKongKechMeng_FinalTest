using CommunityToolkit.Maui;
using EdmundKongKechMeng_FinalTest.MobileApp.Services;
using EdmundKongKechMeng_FinalTest.MobileApp.ViewModels;
using EdmundKongKechMeng_FinalTest.MobileApp.Views;
using Microsoft.Extensions.Logging;

namespace EdmundKongKechMeng_FinalTest.MobileApp
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<AddPostPage>();
            builder.Services.AddSingleton<Question3Page>();
            builder.Services.AddSingleton<Question2Page>();
            builder.Services.AddSingleton<Question3PageViewModel>();
            builder.Services.AddSingleton<Question1Page>();
            builder.Services.AddSingleton<PostRecordService>();
            return builder.Build();
        }
    }
}
