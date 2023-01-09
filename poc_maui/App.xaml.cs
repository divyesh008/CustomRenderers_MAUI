using poc_maui.Views;

namespace poc_maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

        MainPage = new MainPage();
	}
}

