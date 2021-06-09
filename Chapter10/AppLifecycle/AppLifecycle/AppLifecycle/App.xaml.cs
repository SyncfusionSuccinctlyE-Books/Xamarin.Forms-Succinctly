using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace AppLifecycle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        private DateTime _lastActivityTime;
        protected override void OnStart()
        {
            _lastActivityTime = Preferences.Get("LastActivityTime", DateTime.MinValue);
        }

        protected override void OnSleep()
        {
            Preferences.Set("LastActivityTime", DateTime.Now.ToUniversalTime());
        }

        protected override void OnResume()
        {
            _lastActivityTime = Preferences.Get("LastActivityTime", DateTime.MinValue);
        }
    }
}
