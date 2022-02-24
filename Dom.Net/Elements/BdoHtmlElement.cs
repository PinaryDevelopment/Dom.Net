using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Bdo, "The <bdo> HTML element overrides the current directionality of text, so that the text within is rendered in a different direction.", HtmlElementCategoryNames.InlineTextSemantics)]
public class BdoHtmlElement : HtmlElement
{
    public BdoHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
