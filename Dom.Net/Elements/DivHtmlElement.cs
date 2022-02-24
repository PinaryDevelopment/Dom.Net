using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Div, "The <div> HTML element is the generic container for flow content. It has no effect on the content or layout until styled in some way using CSS (e.g. styling is directly applied to it, or some kind of layout model like Flexbox is applied to its parent element).", HtmlElementCategoryNames.TextContent)]
public class DivHtmlElement : HtmlElement
{
    public DivHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
