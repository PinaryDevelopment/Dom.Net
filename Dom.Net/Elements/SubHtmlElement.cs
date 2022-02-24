using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Sub, "The <sub> HTML element specifies inline text which should be displayed as subscript for solely typographical reasons. Subscripts are typically rendered with a lowered baseline using smaller text.", HtmlElementCategoryNames.InlineTextSemantics)]
public class SubHtmlElement : HtmlElement
{
    public SubHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
