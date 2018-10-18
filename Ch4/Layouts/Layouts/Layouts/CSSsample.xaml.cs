using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CSSsample : ContentPage
	{
		public CSSsample ()
		{
			InitializeComponent ();

            //using (var reader =
            //       new StringReader
            //           ("^contentpage { background-color: lightgray; } stacklayout { margin: 20; }"))
            //{
            //    // "this" represents a page
            //    // StyleSheet requires a using Xamarin.Forms.StyleSheets directive
            //    this.Resources.Add(StyleSheet.FromReader(reader));
            //}
            var styleSheet = StyleSheet.FromAssemblyResource(
                IntrospectionExtensions.GetTypeInfo(typeof(CSSsample)).Assembly,
                "Project1.Assets.mystyle.css");
            this.Resources.Add(styleSheet);
        }
	}
}