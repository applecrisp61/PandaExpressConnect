using System;

using Xamarin.Forms;

namespace PandaExpressConnect {
	public class App : Application {
		public App() {

			var testingPage = new TestingPage();

			MainPage = new NavigationPage(testingPage);
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}
