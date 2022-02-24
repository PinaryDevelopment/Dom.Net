using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Blink, "The <blink> HTML element is a non-standard element which causes the enclosed text to flash slowly.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class BlinkHtmlElement : HtmlElement
{
    public BlinkHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
