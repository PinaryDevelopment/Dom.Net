using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Xmp, "The <xmp> HTML element renders text between the start and end tags without interpreting the HTML in between and using a monospaced font. The HTML2 specification recommended that it should be rendered wide enough to allow 80 characters per line.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class XmpHtmlElement : HtmlElement
{
    public XmpHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
