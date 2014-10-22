using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace Mindfire.Web.HtmlGeneration
{
    /// <summary>
    /// An element in a page that can be displayed.
    /// </summary>
	public interface IRenderable
	{
        /// <summary>
        /// Called to put the element into the page.
        /// </summary>
        /// <param name="writer"></param>
		void Render(HtmlTextWriter writer);
	}
}
