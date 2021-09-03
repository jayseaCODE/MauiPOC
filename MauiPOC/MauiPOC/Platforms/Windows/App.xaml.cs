using Microsoft.Maui;

namespace MauiPOC.UWP
{
	public class MiddleApp : MauiWinUIApplication
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}

	public partial class App : MiddleApp
	{
		public App()
		{
			InitializeComponent();
		}
	}
}