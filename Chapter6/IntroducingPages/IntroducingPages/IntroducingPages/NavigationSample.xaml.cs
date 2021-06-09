using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroducingPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationSample : ContentPage
    {
        public NavigationSample()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondaryPage());
        }
    }
}