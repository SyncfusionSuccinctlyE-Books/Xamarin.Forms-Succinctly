using NativeAccess;
using NativeAccess.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(AutoSelectEntry),
           typeof(AutoSelectEntryRenderer))]
namespace NativeAccess.UWP
{
    public class AutoSelectEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var nativeEditText = Control;
                nativeEditText.SelectAll();
            }
        }
    }

}
