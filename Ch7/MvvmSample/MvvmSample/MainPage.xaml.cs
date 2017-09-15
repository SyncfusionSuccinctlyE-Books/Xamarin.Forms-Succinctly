using MvvmSample.ViewModel;
using Xamarin.Forms;

namespace MvvmSample
{
    public partial class MainPage : ContentPage
    {
        // Not using a field here because properties
        // are optimized for data binding
        private PersonViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();

            this.ViewModel = new PersonViewModel();
            this.BindingContext = this.ViewModel;
        }
    }
}
