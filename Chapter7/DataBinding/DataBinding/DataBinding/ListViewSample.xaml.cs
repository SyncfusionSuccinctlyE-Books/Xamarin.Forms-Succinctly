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
    public partial class ListViewSample : ContentPage
    {
        public ListViewSample()
        {
            InitializeComponent();
            var peopleModel = new PeopleModel();
            BindingContext = peopleModel.People;
        }
    }
}