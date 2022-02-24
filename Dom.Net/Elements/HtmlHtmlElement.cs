using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Html, "The <html> HTML element represents the root (top-level element) of an HTML document, so it is also referred to as the root element. All other elements must be descendants of this element.", HtmlElementCategoryNames.MainRoot)]
public class HtmlHtmlElement : HtmlElement
{
    public HtmlHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
