using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Image, "The <image> HTML element is an obsolete remnant of an ancient version of HTML lost in the mists of time; use the standard img element instead. Seriously, the specification even literally uses the words \"Don't ask\" when describing this element.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class ImageHtmlElement : HtmlElement
{
    public ImageHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
