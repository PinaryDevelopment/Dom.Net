using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Rt, "The <rt> HTML element specifies the ruby text component of a ruby annotation, which is used to provide pronunciation, translation, or transliteration information for East Asian typography. The <rt> element must always be contained within a ruby element.", HtmlElementCategoryNames.InlineTextSemantics)]
public class RtHtmlElement : HtmlElement
{
    public RtHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
