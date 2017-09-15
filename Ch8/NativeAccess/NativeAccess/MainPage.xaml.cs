using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NativeAccess
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void PlatformCheck()
        {
            // Label1 is a Label view in the UI
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Label1.FontSize = Device.GetNamedSize(NamedSize.Large, Label1);
                    break;
                case Device.Android:
                    Label1.FontSize = Device.GetNamedSize(NamedSize.Medium, Label1);
                    break;
                case Device.WinPhone:
                    Label1.FontSize = Device.GetNamedSize(NamedSize.Medium, Label1);
                    break;
                case Device.Windows:
                    Label1.FontSize = Device.GetNamedSize(NamedSize.Large, Label1);
                    break;
            }

        }

        private void ConnectivityCheck()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                // Connection is available
            }

            CrossConnectivity.Current.ConnectivityChanged +=
                ((sender, e) =>
                {
        // Connection status changed
    });

        }
    }
}
