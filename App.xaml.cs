using HelloWorldMaui.ViewModels;

namespace HelloWorldMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var tabbedPage = new FreshMvvm.Maui.FreshTabbedNavigationContainer();

        tabbedPage.AddTab<HomePageModel>("Home", "home.png");
        tabbedPage.AddTab<HomePageModel>("Details", "details");
        tabbedPage.AddTab<HomePageModel>("Settings", "settings");


        MainPage = tabbedPage;
    }
}
