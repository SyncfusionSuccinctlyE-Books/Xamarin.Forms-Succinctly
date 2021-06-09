using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Brushes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "Brush_Experimental" });

            MainPage = new RadialGradientPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
