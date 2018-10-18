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
	public partial class ImageWithGestureRecognizerSample : ContentPage
	{
		public ImageWithGestureRecognizerSample ()
		{
			InitializeComponent ();
		}

        private void ImageTap_Tapped(object sender, EventArgs e)
        {
            // Image has been tapped
        }
    }
}