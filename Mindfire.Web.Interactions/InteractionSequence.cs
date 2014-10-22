using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

namespace Mindfire.Web.Interactions
{
    public class InteractionSequence: IEnumerator<Interaction>
    {
        IEnumerator<Interaction> interactions;
        public InteractionSequence(IEnumerable<Interaction> interactions)
        {
            this.interactions = interactions.GetEnumerator();
        }
        
        public bool ExecuteOne(System.Web.HttpContext context)
        {
            var form = context.Request.Form;

            var htmlWriter = new System.Web.UI.HtmlTextWriter(context.Response.Output);
            var html = interactions.Current(context);
            html.Render(htmlWriter);
            return interactions.MoveNext();
        }


        public Interaction Current
        {
            get { return interactions.Current; }
        }

        public void Dispose()
        {
            interactions.Dispose();
        }

        object System.Collections.IEnumerator.Current
        {
            get { return interactions.Current; }
        }

        public bool MoveNext()
        {
            return interactions.MoveNext();
        }

        public void Reset()
        {
            interactions.Reset();
        }

    }
}
