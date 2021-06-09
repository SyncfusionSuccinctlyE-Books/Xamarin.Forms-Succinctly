using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewSample : ContentPage
    {
        public CarouselViewSample()
        {
            InitializeComponent();
            var people = new PeopleModel();
            BindingContext = people;
        }

        private void PeopleList_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            
        }

        private void PeopleList_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            
        }
    }
}