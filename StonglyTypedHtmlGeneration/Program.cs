using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.IO;
using Mindfire.Web.HtmlGeneration;
using System.Diagnostics;
using System.Drawing;

namespace StonglyTypedHtmlGeneration
{
	class Program
	{
        static Div Centre(Div thingToCentre)
        {
            return thingToCentre.style("text-align: center;");
        }

        static Div Border(Color borderColor, Div thingToCentre)
        {
            var colorStyle = string.Format("border:1px solid #{0:x2}{1:x2}{2:x2};", borderColor.R, borderColor.G, borderColor.B);
            return thingToCentre.style(colorStyle);
        }

        static Div Banner(string bannerText)
        {
            return 
                Centre(
                    Border(Color.Red, 
                        H.Div( 
                            H.P(bannerText).style("font-weight:bold; color:red;"))));
        }

		static void Main(string[] args)
		{

			var page = 
			H.Html(
				H.Head(
					H.Title("My Page Title")),
				H.Body(
                    Banner("My Banner Text"),
                    H.Form(H.P(""))
                        .@id("form1")
                        .@action("#"),

    				H.H1("Welcome"),
                    H.P("Here's some text"),
					H.P(H.B("bold"), H.I("italic")),
					H.Div().@id("div1"),

                    H.Div(
                        H.P("para 1"), 
                        H.P("para 2")),

                    // unordered list
                    H.Ul(
                        H.Li("item 1"),
                        H.Li("item 2"),
                        H.Li("item 3")),

                    // ordered list
                    H.Ol(
                        H.Li("item 1"),
                        H.Li("item 2"),
                        H.Li("item 3"))
                    ));

            bool writeToFile = true;

            var path = System.Environment.ExpandEnvironmentVariables("%temp%\\example.html");

            Stream stream = writeToFile
                ? (Stream)new FileStream(path, FileMode.Create, FileAccess.ReadWrite)
                : (Stream)new MemoryStream();

            TextWriter sw = new StreamWriter(stream);
            var writer = new HtmlTextWriter(sw);
            sw.Write(@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Strict//EN""
   ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"">
");

            page.Render(writer);

            stream.Seek(0, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(stream);
            string html = sr.ReadToEnd();
            stream.Close();

            Console.WriteLine(html);
            Console.WriteLine("DONE");

            if (writeToFile) { Process.Start(path); }

            //Console.ReadLine();

		}

	}
}
