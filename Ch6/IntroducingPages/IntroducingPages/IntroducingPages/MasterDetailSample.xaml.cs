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
    public partial class MasterDetailSample : MasterDetailPage
    {
        public MasterDetailSample()
        {
            InitializeComponent();

            // Use IsPresented to programmatically control
            // the visibility of the Master
            this.IsPresented = true;
        }
    }
}