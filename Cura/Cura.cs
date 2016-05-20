using System;

using Xamarin.Forms;

namespace Cura
{
	public class App : Application
	{
		//public static bool UserLogin { get; set; }

		public App ()
		{

			MainPage = new NavigationPage (new CuraLoginPage() );

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

