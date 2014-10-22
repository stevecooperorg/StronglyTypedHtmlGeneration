using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Mindfire.Web.Interactions
{
    public class PageVariable<T> 
    {
        public T Value { get; set; }
        private Guid guid { get; set; }

        public string Id { get { return "var" + guid.ToString("N"); } }

        public PageVariable()
        {
            this.guid = Guid.NewGuid();
        }
    }
}
