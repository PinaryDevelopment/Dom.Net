using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Bgsound, "The <bgsound> HTML element is deprecated. It sets up a sound file to play in the background while the page is used; use audio instead.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class BgsoundHtmlElement : HtmlElement
{
    public BgsoundHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
