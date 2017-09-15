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
    public partial class WorkingWithDatesAndTime : ContentPage
    {
        public WorkingWithDatesAndTime()
        {
            InitializeComponent();
        }

        private void DatePicker1_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime selectedDate = e.NewDate;
        }

        private void TimePicker1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                TimeSpan selectedTime = TimePicker1.Time;
            }

        }
    }
}