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
    public partial class CollectionViewSample : ContentPage
    {
        public CollectionViewSample()
        {
            InitializeComponent();
            var dataModel = new PeopleModel();
            BindingContext = dataModel;
        }

        private void PeopleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // In case of single selection
            var selectedPerson = this.PeopleList.SelectedItem as Person;

            // In case of multi-selection:
            var singlePerson = e.CurrentSelection.FirstOrDefault() as Person;

            var selectedObjects = e.CurrentSelection.Cast<Person>();
            foreach (var person in selectedObjects)
            {
                // Handle your object properties here...
            }
        }


    }
}