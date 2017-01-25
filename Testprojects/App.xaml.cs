using Xamarin.Forms;

namespace Testprojects
{
	public partial class App : Application
	{
		public App()
		{
			int i = 5;
			InitializeComponent();

			MainPage = new TestprojectsPage();
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
