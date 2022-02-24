using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Font, "The <font> HTML element defines the font size, color and face for its content.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class FontHtmlElement : HtmlElement
{
    public FontHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
