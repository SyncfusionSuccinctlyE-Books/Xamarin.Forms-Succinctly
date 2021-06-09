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
    public partial class ValueSelectionSample : ContentPage
    {
        public ValueSelectionSample()
        {
            InitializeComponent();
        }

        private void Switch1_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
        }

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
        }
    }
}