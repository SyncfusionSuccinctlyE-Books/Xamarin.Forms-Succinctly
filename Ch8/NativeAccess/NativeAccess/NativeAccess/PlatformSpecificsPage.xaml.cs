using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace NativeAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatformSpecificsPage : ContentPage
	{
		public PlatformSpecificsPage ()
		{
			InitializeComponent ();

            this.ListView1.On<iOS>().SetSeparatorStyle(SeparatorStyle.FullWidth);
		}
	}
}