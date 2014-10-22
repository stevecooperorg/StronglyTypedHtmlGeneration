 
using System;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;

//
// AUTOMATICALLY CREATED -- DO NOT EDIT
//
namespace Mindfire.Web.HtmlGeneration
{
	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//
	public static partial class H
	{

        ///<summary>
        ///Create a new Html element.
        ///</summary>
		public static Html Html(params IHtmlElement[] contents)
		{
			return new Html(contents);
		}



        ///<summary>
        ///Create a new Head element.
        ///</summary>
		public static Head Head(params IHeadElement[] contents)
		{
			return new Head(contents);
		}



        ///<summary>
        ///Create a new Title element.
        ///</summary>
		public static Title Title(params ITitleElement[] contents)
		{
			return new Title(contents);
		}

        ///<summary
        ///Create a new Title element from string literals.
        ///</summary>
		public static Title Title(params string[] contents)
		{
			return new Title(contents);
		}



        ///<summary>
        ///Create a new Body element.
        ///</summary>
		public static Body Body(params IBodyElement[] contents)
		{
			return new Body(contents);
		}



        ///<summary>
        ///Create a new P element.
        ///</summary>
		public static P P(params IPElement[] contents)
		{
			return new P(contents);
		}

        ///<summary
        ///Create a new P element from string literals.
        ///</summary>
		public static P P(params string[] contents)
		{
			return new P(contents);
		}



        ///<summary>
        ///Create a new Form element.
        ///</summary>
		public static Form Form(params IFormElement[] contents)
		{
			return new Form(contents);
		}



        ///<summary>
        ///Create a new Div element.
        ///</summary>
		public static Div Div(params IDivElement[] contents)
		{
			return new Div(contents);
		}



        ///<summary>
        ///Create a new B element.
        ///</summary>
		public static B B(params IBElement[] contents)
		{
			return new B(contents);
		}

        ///<summary
        ///Create a new B element from string literals.
        ///</summary>
		public static B B(params string[] contents)
		{
			return new B(contents);
		}



        ///<summary>
        ///Create a new I element.
        ///</summary>
		public static I I(params IIElement[] contents)
		{
			return new I(contents);
		}

        ///<summary
        ///Create a new I element from string literals.
        ///</summary>
		public static I I(params string[] contents)
		{
			return new I(contents);
		}



        ///<summary>
        ///Create a new H1 element.
        ///</summary>
		public static H1 H1(params IH1Element[] contents)
		{
			return new H1(contents);
		}

        ///<summary
        ///Create a new H1 element from string literals.
        ///</summary>
		public static H1 H1(params string[] contents)
		{
			return new H1(contents);
		}



        ///<summary>
        ///Create a new H2 element.
        ///</summary>
		public static H2 H2(params IH2Element[] contents)
		{
			return new H2(contents);
		}

        ///<summary
        ///Create a new H2 element from string literals.
        ///</summary>
		public static H2 H2(params string[] contents)
		{
			return new H2(contents);
		}



        ///<summary>
        ///Create a new H3 element.
        ///</summary>
		public static H3 H3(params IH3Element[] contents)
		{
			return new H3(contents);
		}

        ///<summary
        ///Create a new H3 element from string literals.
        ///</summary>
		public static H3 H3(params string[] contents)
		{
			return new H3(contents);
		}



        ///<summary>
        ///Create a new H4 element.
        ///</summary>
		public static H4 H4(params IH4Element[] contents)
		{
			return new H4(contents);
		}

        ///<summary
        ///Create a new H4 element from string literals.
        ///</summary>
		public static H4 H4(params string[] contents)
		{
			return new H4(contents);
		}



        ///<summary>
        ///Create a new H5 element.
        ///</summary>
		public static H5 H5(params IH5Element[] contents)
		{
			return new H5(contents);
		}

        ///<summary
        ///Create a new H5 element from string literals.
        ///</summary>
		public static H5 H5(params string[] contents)
		{
			return new H5(contents);
		}



        ///<summary>
        ///Create a new H6 element.
        ///</summary>
		public static H6 H6(params IH6Element[] contents)
		{
			return new H6(contents);
		}

        ///<summary
        ///Create a new H6 element from string literals.
        ///</summary>
		public static H6 H6(params string[] contents)
		{
			return new H6(contents);
		}



        ///<summary>
        ///Create a new Ul element.
        ///</summary>
		public static Ul Ul(params IUlElement[] contents)
		{
			return new Ul(contents);
		}



        ///<summary>
        ///Create a new Ol element.
        ///</summary>
		public static Ol Ol(params IOlElement[] contents)
		{
			return new Ol(contents);
		}



        ///<summary>
        ///Create a new Li element.
        ///</summary>
		public static Li Li(params ILiElement[] contents)
		{
			return new Li(contents);
		}

        ///<summary
        ///Create a new Li element from string literals.
        ///</summary>
		public static Li Li(params string[] contents)
		{
			return new Li(contents);
		}




	}


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Html HTML element.
    ///</summary>
    public partial class Html: Tag<IHtmlElement>, IHeadElement,   IRenderable
    {
        ///<summary
        ///Create a new Html element.
        ///</summary>
		public Html(params IHtmlElement[] contents): base("html", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Html @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Html @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Html @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Html @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}



		
    }

    ///<summary
    ///The IHtmlElement interface, representing elements that can be in a Html.
    ///</summary>
    public interface IHtmlElement: IRenderable
    {
    }



	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Head HTML element.
    ///</summary>
    public partial class Head: Tag<IHeadElement>, IHtmlElement,   IRenderable
    {
        ///<summary
        ///Create a new Head element.
        ///</summary>
		public Head(params IHeadElement[] contents): base("head", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Head @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Head @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Head @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Head @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}



		
    }

    ///<summary
    ///The IHeadElement interface, representing elements that can be in a Head.
    ///</summary>
    public interface IHeadElement: IRenderable
    {
    }



	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Title HTML element.
    ///</summary>
    public partial class Title: Tag<ITitleElement>, IHeadElement,   IRenderable
    {
        ///<summary
        ///Create a new Title element.
        ///</summary>
		public Title(params ITitleElement[] contents): base("title", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Title @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Title @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Title @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Title @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new Title element populated with string literals.
        ///</summary>
		public Title(params string[] contents): base("title", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static ITitleElement[] ToLiterals(string[] contents)
		{
			var results = new List<ITitleElement>();
			
			foreach(var content in contents)
			{
				results.Add(new TitleLiteral(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The ITitleElement interface, representing elements that can be in a Title.
    ///</summary>
    public interface ITitleElement: IRenderable
    {
    }

    public partial class TitleLiteral: ITitleElement, IRenderable
    {
		string literalText;
		public TitleLiteral(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Body HTML element.
    ///</summary>
    public partial class Body: Tag<IBodyElement>, IHtmlElement,   IRenderable
    {
        ///<summary
        ///Create a new Body element.
        ///</summary>
		public Body(params IBodyElement[] contents): base("body", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Body @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Body @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Body @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Body @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}



		
    }

    ///<summary
    ///The IBodyElement interface, representing elements that can be in a Body.
    ///</summary>
    public interface IBodyElement: IRenderable
    {
    }



	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A P HTML element.
    ///</summary>
    public partial class P: Tag<IPElement>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new P element.
        ///</summary>
		public P(params IPElement[] contents): base("p", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public P @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public P @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public P @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public P @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new P element populated with string literals.
        ///</summary>
		public P(params string[] contents): base("p", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IPElement[] ToLiterals(string[] contents)
		{
			var results = new List<IPElement>();
			
			foreach(var content in contents)
			{
				results.Add(new PLiteral(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IPElement interface, representing elements that can be in a P.
    ///</summary>
    public interface IPElement: IRenderable
    {
    }

    public partial class PLiteral: IPElement, IRenderable
    {
		string literalText;
		public PLiteral(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Form HTML element.
    ///</summary>
    public partial class Form: Tag<IFormElement>, IBodyElement, IDivElement,   IRenderable
    {
        ///<summary
        ///Create a new Form element.
        ///</summary>
		public Form(params IFormElement[] contents): base("form", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a action attribute
        ///</summary>
		public Form @action(string actionValue)
		{
			this.attributes.Add("action", actionValue);
			return this;
		}


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Form @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Form @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Form @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Form @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}



		
    }

    ///<summary
    ///The IFormElement interface, representing elements that can be in a Form.
    ///</summary>
    public interface IFormElement: IRenderable
    {
    }



	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Div HTML element.
    ///</summary>
    public partial class Div: Tag<IDivElement>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new Div element.
        ///</summary>
		public Div(params IDivElement[] contents): base("div", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Div @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Div @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Div @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Div @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}



		
    }

    ///<summary
    ///The IDivElement interface, representing elements that can be in a Div.
    ///</summary>
    public interface IDivElement: IRenderable
    {
    }



	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A B HTML element.
    ///</summary>
    public partial class B: Tag<IBElement>, IPElement,   IRenderable
    {
        ///<summary
        ///Create a new B element.
        ///</summary>
		public B(params IBElement[] contents): base("b", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public B @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public B @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public B @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public B @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new B element populated with string literals.
        ///</summary>
		public B(params string[] contents): base("b", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IBElement[] ToLiterals(string[] contents)
		{
			var results = new List<IBElement>();
			
			foreach(var content in contents)
			{
				results.Add(new BLiteral(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IBElement interface, representing elements that can be in a B.
    ///</summary>
    public interface IBElement: IRenderable
    {
    }

    public partial class BLiteral: IBElement, IRenderable
    {
		string literalText;
		public BLiteral(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A I HTML element.
    ///</summary>
    public partial class I: Tag<IIElement>, IPElement,   IRenderable
    {
        ///<summary
        ///Create a new I element.
        ///</summary>
		public I(params IIElement[] contents): base("i", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public I @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public I @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public I @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public I @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new I element populated with string literals.
        ///</summary>
		public I(params string[] contents): base("i", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IIElement[] ToLiterals(string[] contents)
		{
			var results = new List<IIElement>();
			
			foreach(var content in contents)
			{
				results.Add(new ILiteral(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IIElement interface, representing elements that can be in a I.
    ///</summary>
    public interface IIElement: IRenderable
    {
    }

    public partial class ILiteral: IIElement, IRenderable
    {
		string literalText;
		public ILiteral(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A H1 HTML element.
    ///</summary>
    public partial class H1: Tag<IH1Element>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new H1 element.
        ///</summary>
		public H1(params IH1Element[] contents): base("h1", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public H1 @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public H1 @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public H1 @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public H1 @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new H1 element populated with string literals.
        ///</summary>
		public H1(params string[] contents): base("h1", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IH1Element[] ToLiterals(string[] contents)
		{
			var results = new List<IH1Element>();
			
			foreach(var content in contents)
			{
				results.Add(new H1Literal(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IH1Element interface, representing elements that can be in a H1.
    ///</summary>
    public interface IH1Element: IRenderable
    {
    }

    public partial class H1Literal: IH1Element, IRenderable
    {
		string literalText;
		public H1Literal(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A H2 HTML element.
    ///</summary>
    public partial class H2: Tag<IH2Element>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new H2 element.
        ///</summary>
		public H2(params IH2Element[] contents): base("h2", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public H2 @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public H2 @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public H2 @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public H2 @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new H2 element populated with string literals.
        ///</summary>
		public H2(params string[] contents): base("h2", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IH2Element[] ToLiterals(string[] contents)
		{
			var results = new List<IH2Element>();
			
			foreach(var content in contents)
			{
				results.Add(new H2Literal(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IH2Element interface, representing elements that can be in a H2.
    ///</summary>
    public interface IH2Element: IRenderable
    {
    }

    public partial class H2Literal: IH2Element, IRenderable
    {
		string literalText;
		public H2Literal(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A H3 HTML element.
    ///</summary>
    public partial class H3: Tag<IH3Element>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new H3 element.
        ///</summary>
		public H3(params IH3Element[] contents): base("h3", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public H3 @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public H3 @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public H3 @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public H3 @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new H3 element populated with string literals.
        ///</summary>
		public H3(params string[] contents): base("h3", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IH3Element[] ToLiterals(string[] contents)
		{
			var results = new List<IH3Element>();
			
			foreach(var content in contents)
			{
				results.Add(new H3Literal(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IH3Element interface, representing elements that can be in a H3.
    ///</summary>
    public interface IH3Element: IRenderable
    {
    }

    public partial class H3Literal: IH3Element, IRenderable
    {
		string literalText;
		public H3Literal(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A H4 HTML element.
    ///</summary>
    public partial class H4: Tag<IH4Element>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new H4 element.
        ///</summary>
		public H4(params IH4Element[] contents): base("h4", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public H4 @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public H4 @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public H4 @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public H4 @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new H4 element populated with string literals.
        ///</summary>
		public H4(params string[] contents): base("h4", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IH4Element[] ToLiterals(string[] contents)
		{
			var results = new List<IH4Element>();
			
			foreach(var content in contents)
			{
				results.Add(new H4Literal(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IH4Element interface, representing elements that can be in a H4.
    ///</summary>
    public interface IH4Element: IRenderable
    {
    }

    public partial class H4Literal: IH4Element, IRenderable
    {
		string literalText;
		public H4Literal(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A H5 HTML element.
    ///</summary>
    public partial class H5: Tag<IH5Element>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new H5 element.
        ///</summary>
		public H5(params IH5Element[] contents): base("h5", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public H5 @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public H5 @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public H5 @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public H5 @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new H5 element populated with string literals.
        ///</summary>
		public H5(params string[] contents): base("h5", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IH5Element[] ToLiterals(string[] contents)
		{
			var results = new List<IH5Element>();
			
			foreach(var content in contents)
			{
				results.Add(new H5Literal(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IH5Element interface, representing elements that can be in a H5.
    ///</summary>
    public interface IH5Element: IRenderable
    {
    }

    public partial class H5Literal: IH5Element, IRenderable
    {
		string literalText;
		public H5Literal(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A H6 HTML element.
    ///</summary>
    public partial class H6: Tag<IH6Element>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new H6 element.
        ///</summary>
		public H6(params IH6Element[] contents): base("h6", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public H6 @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public H6 @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public H6 @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public H6 @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new H6 element populated with string literals.
        ///</summary>
		public H6(params string[] contents): base("h6", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static IH6Element[] ToLiterals(string[] contents)
		{
			var results = new List<IH6Element>();
			
			foreach(var content in contents)
			{
				results.Add(new H6Literal(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The IH6Element interface, representing elements that can be in a H6.
    ///</summary>
    public interface IH6Element: IRenderable
    {
    }

    public partial class H6Literal: IH6Element, IRenderable
    {
		string literalText;
		public H6Literal(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        


	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Ul HTML element.
    ///</summary>
    public partial class Ul: Tag<IUlElement>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new Ul element.
        ///</summary>
		public Ul(params IUlElement[] contents): base("ul", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Ul @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Ul @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Ul @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Ul @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}



		
    }

    ///<summary
    ///The IUlElement interface, representing elements that can be in a Ul.
    ///</summary>
    public interface IUlElement: IRenderable
    {
    }



	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Ol HTML element.
    ///</summary>
    public partial class Ol: Tag<IOlElement>, IBodyElement, IDivElement, IFormElement,   IRenderable
    {
        ///<summary
        ///Create a new Ol element.
        ///</summary>
		public Ol(params IOlElement[] contents): base("ol", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Ol @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Ol @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Ol @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Ol @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}



		
    }

    ///<summary
    ///The IOlElement interface, representing elements that can be in a Ol.
    ///</summary>
    public interface IOlElement: IRenderable
    {
    }



	//
	// AUTOMATICALLY CREATED -- DO NOT EDIT
	//


    ///<summary
    ///A Li HTML element.
    ///</summary>
    public partial class Li: Tag<ILiElement>, IUlElement, IOlElement,   IRenderable
    {
        ///<summary
        ///Create a new Li element.
        ///</summary>
		public Li(params ILiElement[] contents): base("li", contents)
		{
			CustomSetup();
		}

        partial void CustomSetup();


        ///<summary
        ///Add a id attribute
        ///</summary>
		public Li @id(string idValue)
		{
			this.attributes.Add("id", idValue);
			return this;
		}


        ///<summary
        ///Add a title attribute
        ///</summary>
		public Li @title(string titleValue)
		{
			this.attributes.Add("title", titleValue);
			return this;
		}


		///<summary
        ///Add a class attribute
        ///</summary>
		public Li @class(CssClass classValue)
		{
			this.cssClass = classValue;
			return this;
		}
        ///<summary
        ///Add a style attribute
        ///</summary>
		public Li @style(string styleValue)
		{
			var currentStyle = "";
			if (this.attributes.TryGetValue("style", out currentStyle))
			{
				this.attributes.Remove("style");
				this.attributes.Add("style", currentStyle+styleValue);
			}
			else			
			{
				this.attributes.Add("style", styleValue);
			}
			return this;
		}


        ///<summary
        ///Create a new Li element populated with string literals.
        ///</summary>
		public Li(params string[] contents): base("li", ToLiterals(contents))
		{
		}
		
		///<summary
        ///Create new literals
        ///</summary>
		private static ILiElement[] ToLiterals(string[] contents)
		{
			var results = new List<ILiElement>();
			
			foreach(var content in contents)
			{
				results.Add(new LiLiteral(content));
			}
			
			return results.ToArray();
		}


		
    }

    ///<summary
    ///The ILiElement interface, representing elements that can be in a Li.
    ///</summary>
    public interface ILiElement: IRenderable
    {
    }

    public partial class LiLiteral: ILiElement, IRenderable
    {
		string literalText;
		public LiLiteral(string literalText)
		{
			this.literalText = literalText;
		}
		
		public void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(this.literalText);
		}
    }        





}

