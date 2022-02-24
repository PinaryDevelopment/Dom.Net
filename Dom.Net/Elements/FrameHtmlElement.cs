using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Frame, "The <frame> HTML element defines a particular area in which another HTML document can be displayed. A frame should be used within a frameset.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class FrameHtmlElement : HtmlElement
{
    public FrameHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
