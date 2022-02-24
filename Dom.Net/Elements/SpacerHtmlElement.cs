using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Spacer, "The <spacer> HTML element is an obsolete HTML element which allowed insertion of empty spaces on pages. It was devised by Netscape to accomplish the same effect as a single-pixel layout image, which was something web designers used to use to add white spaces to web pages without actually using an image. However, <spacer> no longer supported by any major browser and the same effects can now be achieved using simple CSS.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class SpacerHtmlElement : HtmlElement
{
    public SpacerHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
