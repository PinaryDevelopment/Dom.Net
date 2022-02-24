using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Wbr, "The <wbr> HTML element represents a word break opportunity—a position within text where the browser may optionally break a line, though its line-breaking rules would not otherwise create a break at that location.", HtmlElementCategoryNames.InlineTextSemantics)]
public class WbrHtmlElement : HtmlElement
{
    public WbrHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
