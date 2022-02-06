using FreshMvvm.Maui.Extensions;
using HelloWorldMaui.Pages;
using HelloWorldMaui.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorldMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddTransient<HomePageModel>();
		builder.Services.AddTransient<HomePage>();

		builder.Services.UseFreshMvvm();


		return builder.Build();
	}
}
