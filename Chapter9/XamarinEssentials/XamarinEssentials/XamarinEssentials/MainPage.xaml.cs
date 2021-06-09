using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XamarinEssentials
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private async void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if(e.NetworkAccess != NetworkAccess.Internet)
            {
                await DisplayAlert("Warning", "Limited internet connection", "OK");
                // Do additional work to limit network access...
            }
        }

        public async Task SendSms(string messageText, string[] recipients)
        {
            var message = new SmsMessage(messageText, recipients);
            await Sms.ComposeAsync(message);
        }

        private async Task OpenBrowser()
        {
            await Browser.OpenAsync("https://www.microsoft.com");
        }

        private async Task OpenLauncher()
        {
            string uri = "mailto://somebody@something.com";
            var canOpen = await Launcher.CanOpenAsync(uri);
            if(canOpen)
                await Launcher.OpenAsync("mailto://somebody@something.com");
        }

        private void CheckNetworkConnection()
        {
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                // Internet is available

                var profiles = Connectivity.ConnectionProfiles;
                if(profiles.Contains(ConnectionProfile.WiFi))
                {
                    // WiFi connection
                }
            }
        }
    }
}
