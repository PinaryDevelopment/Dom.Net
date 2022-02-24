using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Frameset, "The <frameset> HTML element is used to contain frame elements.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class FramesetHtmlElement : HtmlElement
{
    public FramesetHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
