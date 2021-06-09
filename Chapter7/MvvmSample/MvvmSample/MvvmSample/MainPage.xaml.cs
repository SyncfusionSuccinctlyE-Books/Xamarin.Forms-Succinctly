using MvvmSample.ViewModel;
using Xamarin.Forms;

namespace MvvmSample
{
    public partial class MainPage : ContentPage
    {
        private PersonViewModel ViewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ViewModel = new PersonViewModel();
            BindingContext = ViewModel;
        }
    }
}
