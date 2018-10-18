using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlexLayoutSample : ContentPage
	{
		public FlexLayoutSample ()
		{
			InitializeComponent ();
		}

        private void Button1_Clicked(object sender, EventArgs e)
        {

        }
    }
}