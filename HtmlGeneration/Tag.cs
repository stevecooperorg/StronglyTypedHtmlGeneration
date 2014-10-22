using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace Mindfire.Web.HtmlGeneration
{
	public class Tag<ContainerType> : IRenderable where ContainerType : IRenderable
	{
		string tagName;
		ContainerType[] contained;

        protected CssClass cssClass;
		
    

        protected Dictionary<string, string> attributes = new Dictionary<string,string>();

		public Tag(string tagName, params ContainerType[] contained)
		{
			this.tagName = tagName;
			this.contained = contained;
		}

        /// <summary>
        /// Put the element on the page. Renders a tag, a set of attributes, and any content
        /// </summary>
        /// <param name="writer"></param>
		public void Render(HtmlTextWriter writer)
		{
			writer.WriteBeginTag(tagName);
            foreach (var attribute in attributes)
            {
                writer.WriteAttribute(attribute.Key, attribute.Value);
            }

            if (this.cssClass != null)
            {
                writer.WriteAttribute("class", this.cssClass.Name);
            }

            writer.Write(HtmlTextWriter.TagRightChar);
 

            // render the contents
            foreach (var inner in contained)
			{
				inner.Render(writer);
			}

            // close it off
            writer.WriteEndTag(tagName);

            // flush -- otherwise, the stream we're writing to might not be populated
            writer.Flush();
		}

	}
}
