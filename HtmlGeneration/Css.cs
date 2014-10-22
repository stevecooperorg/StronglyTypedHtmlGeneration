using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Mindfire.Web.HtmlGeneration
{
    public class Css: IHeadElement 
    {
        private List<CssClass> classes = new List<CssClass>();

        protected CssClass AddClass()
        {
            var cl = new CssClass("class" + Guid.NewGuid().ToString("N"), this, CssClassType.Custom);
            this.classes.Add(cl);
            return cl;
        }

        public Css()
        {
            this.Body = new CssClass("body", this, CssClassType.Element);
            this.classes.Add(this.Body);
        }

        public CssClass Body { get; private set; }

        public void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.WriteBeginTag("style");
            writer.WriteAttribute("type", "text/css");
            writer.Write(">");
            foreach(var cl in classes)
            {
                cl.Render(writer);
            }
            writer.WriteEndTag("style");
        }

        public Css WithClass(out CssClass cl)
        {
            cl = this.AddClass();
            return this;
        }
                
    }

    internal enum CssClassType
    {
        Custom,
        Element,
    }

    public class CssClass
    {

        public string Name { get; private set; }

        private Css css;
        CssClassType classType;

        internal CssClass(string name, Css css, CssClassType classType)
        {
            this.Name = name;
            this.css = css;
            this.classType = classType;
        }

        public Css WithClass(out CssClass cl)
        {
            return css.WithClass(out cl);
        }

        internal void Render(System.Web.UI.HtmlTextWriter writer)
        {
            var name = this.classType == CssClassType.Element ? this.Name : "." + this.Name;
            var css = name + "\r\n{\r\n" 
                + (Color.HasValue ? "    color: " + ColorTranslator.ToHtml(Color.Value) + ";\r\n" : "")
                + (BackColor.HasValue ? "    background-color: " + ColorTranslator.ToHtml(BackColor.Value) + ";\r\n" : "")
                + "}\r\n";

            writer.WriteLine(css);
            
        }

        public System.Drawing.Color? Color { get; set; }
        public System.Drawing.Color? BackColor { get; set; }
    }
    
}
