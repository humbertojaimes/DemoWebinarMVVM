using Xamarin.Forms;

namespace DemoWebinarMVVM
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new DemoWebinarMVVMPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

