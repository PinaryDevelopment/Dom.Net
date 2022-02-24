using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Plaintext, "The <plaintext> HTML element renders everything following the start tag as raw text, ignoring any following HTML. There is no closing tag, since everything after it is considered raw text.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class PlaintextHtmlElement : HtmlElement
{
    public PlaintextHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
