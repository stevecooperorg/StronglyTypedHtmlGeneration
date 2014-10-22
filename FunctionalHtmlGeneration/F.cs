using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalHtmlGeneration
{
    public delegate string Generator();

    public delegate Generator Html(Head h, Body b);
    public delegate Generator Head(Title t);
    public delegate Generator Title(string text);
    public delegate Generator Body(params BodyElement[] bodyElements);
    public delegate Generator BodyElement();

}
