using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Big, "The <big> HTML deprecated element renders the enclosed text at a font size one level larger than the surrounding text (medium becomes large, for example). The size is capped at the browser's maximum permitted font size.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class BigHtmlElement : HtmlElement
{
    public BigHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
