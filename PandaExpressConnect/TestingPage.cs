using System;
using System.Text;

using Xamarin.Forms;

using Microsoft.WindowsAzure.MobileServices;
using FlirtyLocation;

namespace PandaExpressConnect {
	public class TestingPage : ContentPage {
		public TestingPage() {
			Content = new StackLayout {

				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,

				Children = {
					new Label { Text = "Testing Page" }
				}
			};

			Device.StartTimer(TimeSpan.FromSeconds(5), () => {
				var msg = TestPandaConnect();

				var sl = this.Content as StackLayout;
				sl?.Children.Add(new Label { Text = msg });

				return true;
			});
		}

		private string TestPandaConnect() {
			LocationMeasurementManager commMgr = null;
			StringBuilder sb = new StringBuilder();

			try {
				commMgr = LocationMeasurementManager.DefaultManager;
			}
			catch (MobileServiceInvalidOperationException msioe) {
				sb.AppendLine($"Mobile service invalid operation exception: {msioe.Message}");
				return sb.ToString();
			}
			catch (Exception e) {
				sb.AppendLine($"Exception: {e.Message}");
				sb.AppendLine($"Inner exception: {e.InnerException}");
				return sb.ToString();
			}

			return $"CommMgr established without exception. {commMgr.CurrentClient.MobileAppUri.AbsolutePath}";

		}
	}
}

