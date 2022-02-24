using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Figure, "The <figure> HTML element represents self-contained content, potentially with an optional caption, which is specified using the figcaption element. The figure, its caption, and its contents are referenced as a single unit.", HtmlElementCategoryNames.TextContent)]
public class FigureHtmlElement : HtmlElement
{
    public FigureHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
