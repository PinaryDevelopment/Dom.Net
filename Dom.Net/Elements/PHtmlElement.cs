using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.P, "The <p> HTML element represents a paragraph. Paragraphs are usually represented in visual media as blocks of text separated from adjacent blocks by blank lines and/or first-line indentation, but HTML paragraphs can be any structural grouping of related content, such as images or form fields.", HtmlElementCategoryNames.TextContent)]
public class PHtmlElement : HtmlElement
{
    public PHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
