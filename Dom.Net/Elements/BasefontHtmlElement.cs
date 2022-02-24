using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Basefont, "The <basefont> HTML element is deprecated. It sets a default font face, size, and color for the other elements which are descended from its parent element. With this set, the font's size can then be varied relative to the base size using the font element.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class BasefontHtmlElement : HtmlElement
{
    public BasefontHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
