using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;
using System;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata("", "", HtmlElementCategoryNames.FauxElements)]
public class CommentFauxHtmlElement : HtmlElement
{
    public CommentFauxHtmlElement(string contents) : base(Array.Empty<HtmlAttribute>(), contents) { }
}
