using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindfire.Web.HtmlGeneration
{
    public partial class Html
    {
        partial void CustomSetup()
        {
            this.attributes.Add("xmlns", "http://www.w3.org/1999/xhtml");
            this.attributes.Add("xmlns:lang", "en");
        }
    }
}
