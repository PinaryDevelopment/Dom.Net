using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Marquee, "The <marquee> HTML element is used to insert a scrolling area of text. You can control what happens when the text reaches the edges of its content area using its attributes.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class MarqueeHtmlElement : HtmlElement
{
    public MarqueeHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
