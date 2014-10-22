using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalHtmlGeneration
{
    public static class H
    {
        public static Generator Html(Generator head, Generator body)
        {
            return wraptag("html", head, body);
        }

        public static Generator Head(params Generator[] head)
        {
            return wraptag("head", head);
        }

        public static Generator Title(Generator title)
        {
            return wraptag("title", title);
        }

        public static Generator Body(params Generator[] body)
        {
            return wraptag("body", body);
        }

        public static Generator Const(string s)
        {
            return () => s;
        }

        public static Generator Nil
        {
            get
            {
                return () => string.Empty;
            }
        }

        private static Generator tagstart(string tagname)
        {
            return () => "<" + tagname + ">";
        }

        private static Generator tagend(string tagname)
        {
            return () => "</" + tagname + ">";
        }

        private static Generator wraptag(string tagName, params Generator[] gens)
        {
            var newList = new List<Generator>();
            newList.Add(tagstart(tagName));
            newList.AddRange(gens);
            newList.Add(tagend(tagName));

            return cat(newList.ToArray());
        }

        private static Generator cat(Generator[] gens)
        {
            return () =>
            {
                StringBuilder sb = new StringBuilder();
                foreach (var g in gens)
                {
                    sb.Append(g());
                }
                return sb.ToString();
            };
        }

    }
}
