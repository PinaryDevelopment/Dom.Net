using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Keygen, "The <keygen> HTML element exists to facilitate generation of key material, and submission of the public key as part of an HTML form. This mechanism is designed for use with Web-based certificate management systems. It is expected that the <keygen> element will be used in an HTML form along with other information needed to construct a certificate request, and that the result of the process will be a signed certificate.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class KeygenHtmlElement : HtmlElement
{
    public KeygenHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
