using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Figcaption, "The <figcaption> HTML element represents a caption or legend describing the rest of the contents of its parent figure element.", HtmlElementCategoryNames.TextContent)]
public class FigcaptionHtmlElement : HtmlElement
{
    public FigcaptionHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
