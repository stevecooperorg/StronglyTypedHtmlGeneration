using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Mindfire.Web.HtmlGeneration;
using System.Drawing;

namespace Mindfire.Web.Interactions.Sample
{
    public class Default : IHttpHandler, System.Web.SessionState.IRequiresSessionState 
    {
        public void ProcessRequest(HttpContext context)
        {
            var interactionSequence = context.Session["Interaction"] as InteractionSequence;

            if (interactionSequence == null)
            {
                interactionSequence = new InteractionSequence(GetDefaultInteraction());
                context.Session["Interaction"] = interactionSequence;
                interactionSequence.MoveNext();
            }

            bool moreInteractionsExist = interactionSequence.ExecuteOne(context);

            if (!moreInteractionsExist)
            {
                context.Session.Remove("Interaction");
            }
        }

        private IEnumerable<Interaction> GetDefaultInteraction()
        {
            var textBoxContent = new PageVariable<string>();
            yield return HomePage(textBoxContent);
            yield return ThanksPage(textBoxContent);
        }
        
        private Interaction ThanksPage(PageVariable<string> textBoxContent)
        {
            return context => StyledPage(context, "Thanks!", c => H.P("Thanks for visiting. You said " + textBoxContent.Value));
        }

        private delegate IBodyElement BodyGenerator(HttpContext context);

        private Html StyledPage(HttpContext context, string title, BodyGenerator generator)
        {
            var css = new StyleSheet();

            return H.Html(
                    H.Head(
                        H.Title(title), 
                        css),
                    H.Body(
                        H.Div(H.H1("Interactions").@class(css.Title)),
                        generator(context),
                        H.P("This page generated " + DateTime.Now.ToString()).@class(css.Footer)
                    ));
        }

        private class StyleSheet : Css
        {
            public StyleSheet(): base()
            {
                Title = this.AddClass();
                Footer = this.AddClass();

                Title.Color = Color.Chocolate;
                Footer.Color = Color.Blue;
                Footer.BackColor = Color.Red;

                this.Body.Color = Color.DarkBlue;
            }

            public CssClass Title { get; private set; }
            public CssClass Footer { get; private set; }
        }

        private Interaction HomePage(PageVariable<string> textBoxContent)
        {
            BodyGenerator body = ctx => H.Div(
                        H.P("Welcome to the homepage"),
                        H.Form(
                            H.P(
                                new TextBox(textBoxContent),
                                new Button(),
                                new Button())).id("form1")
                        );
            return context => StyledPage(context, "Homepage", body);
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}
