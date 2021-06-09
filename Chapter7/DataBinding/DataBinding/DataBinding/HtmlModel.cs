using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding
{
    public class HtmlModel
    {
        public string HtmlContent { get; set; }

        public HtmlModel()
        {
            HtmlContent = "<div><h1>Header</h1></div>";
        }
    }
}
