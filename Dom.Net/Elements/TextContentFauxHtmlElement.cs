using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;
using System;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata("", "", HtmlElementCategoryNames.FauxElements)]
public class TextContentFauxHtmlElement : HtmlElement
{
    public TextContentFauxHtmlElement(string contents) : base(Array.Empty<HtmlAttribute>(), contents) { }
}
