using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Ol, "The <ol> HTML element represents an ordered list of items — typically rendered as a numbered list.", HtmlElementCategoryNames.TextContent)]
public class OlHtmlElement : HtmlElement
{
    public OlHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
