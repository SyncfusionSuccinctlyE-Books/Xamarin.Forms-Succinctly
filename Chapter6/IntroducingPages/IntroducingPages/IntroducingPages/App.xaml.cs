using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroducingPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Replace with for an example about navigation
            MainPage = new NavigationPage(new NavigationSample());

            //MainPage = new CarouselPageSample();
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
