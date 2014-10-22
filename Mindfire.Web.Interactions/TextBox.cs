using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mindfire.Web.Interactions;

namespace Mindfire.Web.HtmlGeneration
{
    public class TextBox: Tag<IBodyElement>, IDivElement, IPElement, IRenderable
    {
        PageVariable<string> content;
        public TextBox(PageVariable<string> content)
            : base("input")
        {
            this.attributes.Add("type", "text");
            this.attributes.Add("id", content.Id.ToString());
            this.attributes.Add("name", content.Id.ToString());

            this.content = content;
        }
    }
}
