using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindfire.Web.Interactions
{
    public class PageSequence
    {
        public static PageSequence define_page_sequence(string name)
        {
            return new PageSequence(name);
        }

        public string Name { get; set; }

        internal PageSequence(string name)
        {

        }

        public PageSequence with_an
        {
            get { return this; }
        }

        public PageSequence with_a
        {
            get { return this; }
        }

        public PageSequence and_a
        {
            get { return this; }
        }

        public PageSequence and_the
        {
            get { return this; }
        }

        public PageSequence input_field(PageVariable<string> variable)
        {
            return this;
        }

        public PageSequence submit_button
        {
            get { return this; }
        }


        public PageSequence Then_a_page
        {
            get { return new PageSequence(""); }
        }

        public PageSequence link
        {
            get { return this; }
        }

        public PageSequence saying(string linkText)
        {
            return this;
        }

        public PageSequence to(string url)
        {
            return this;
        }
        public PageSequence paragraph(string text, PageVariable<string> variable)
        {
            return this;
        }



    }
}
