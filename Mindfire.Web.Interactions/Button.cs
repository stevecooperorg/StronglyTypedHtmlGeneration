using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindfire.Web.HtmlGeneration
{
    public class Button: Tag<IBodyElement>, IDivElement, IPElement, IRenderable
    {
        public Button()
            : base("input")
        {
            this.attributes.Add("type", "submit");
        }
    }
}
