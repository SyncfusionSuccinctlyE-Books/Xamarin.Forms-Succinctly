using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CommonViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayAlertPage : ContentPage
    {
        public DisplayAlertPage()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            bool result =
                await DisplayAlert("Title", "Do you wish to continue?", "OK", "Cancel");

        }
    }
}