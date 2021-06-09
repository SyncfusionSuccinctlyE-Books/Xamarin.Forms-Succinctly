using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using NativeAccess;
using NativeAccess.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AutoSelectEntry),
           typeof(AutoSelectEntryRenderer))]
namespace NativeAccess.iOS
{
    public class AutoSelectEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            var nativeTextField = Control;
            nativeTextField.EditingDidBegin += (object sender, EventArgs eIos) =>
            {
                nativeTextField.PerformSelector(new ObjCRuntime
                               .Selector("selectAll"),
                null, 0.0f);
            };
        }
    }

}