using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalHtmlGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            var page =
            H.Html(
                H.Head(
                    H.Title(
                        H.Const("Welcome"))),
                H.Body(
                    H.Const("this is the home page")));

            var html = page();
            Console.WriteLine(html);
            Console.WriteLine("DONE");
            Console.ReadLine();

        }
    }
}
