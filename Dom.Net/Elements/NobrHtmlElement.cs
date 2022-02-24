using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Nobr, "The <nobr> HTML element prevents the text it contains from automatically wrapping across multiple lines, potentially resulting in the user having to scroll horizontally to see the entire width of the text.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class NobrHtmlElement : HtmlElement
{
    public NobrHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
