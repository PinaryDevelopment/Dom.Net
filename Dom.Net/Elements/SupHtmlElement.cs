using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Sup, "The <sup> HTML element specifies inline text which is to be displayed as superscript for solely typographical reasons. Superscripts are usually rendered with a raised baseline using smaller text.", HtmlElementCategoryNames.InlineTextSemantics)]
public class SupHtmlElement : HtmlElement
{
    public SupHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
