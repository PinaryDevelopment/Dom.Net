using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Pre, "The <pre> HTML element represents preformatted text which is to be presented exactly as written in the HTML file. The text is typically rendered using a non-proportional, or \"monospaced, font.Whitespace inside this element is displayed as written.", HtmlElementCategoryNames.TextContent)]
public class PreHtmlElement : HtmlElement
{
    public PreHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
