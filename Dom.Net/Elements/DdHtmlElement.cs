using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Dd, "The <dd> HTML element provides the description, definition, or value for the preceding term (dt) in a description list (dl).", HtmlElementCategoryNames.TextContent)]
public class DdHtmlElement : HtmlElement
{
    public DdHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
