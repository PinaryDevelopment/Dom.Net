using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Center, "The <center> HTML element is a block-level element that displays its block-level or inline contents centered horizontally within its containing element. The container is usually, but isn't required to be, body.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class CenterHtmlElement : HtmlElement
{
    public CenterHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
