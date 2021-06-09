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
    public partial class ActivityIndicatorSample : ContentPage
    {
        public ActivityIndicatorSample()
        {
            InitializeComponent();
        }

        private void EnableIndicator()
        {
            this.ActivityIndicator1.IsVisible = true;
            this.ActivityIndicator1.IsRunning = true;

            // Do your stuff here...
            this.ActivityIndicator1.IsRunning = false;
            this.ActivityIndicator1.IsVisible = false;
        }
    }
}