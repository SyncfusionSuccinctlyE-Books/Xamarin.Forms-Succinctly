using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "IndicatorView_Experimental" }); 
            InitializeComponent();

            MainPage = new CarouselViewSample();
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
