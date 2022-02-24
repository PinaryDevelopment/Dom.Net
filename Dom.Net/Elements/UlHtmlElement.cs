using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Ul, "The <ul> HTML element represents an unordered list of items, typically rendered as a bulleted list.", HtmlElementCategoryNames.TextContent)]
public class UlHtmlElement : HtmlElement
{
    public UlHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
