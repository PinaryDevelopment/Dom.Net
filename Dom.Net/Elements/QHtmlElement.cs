using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Q, "The <q> HTML element indicates that the enclosed text is a short inline quotation. Most modern browsers implement this by surrounding the text in quotation marks. This element is intended for short quotations that don't require paragraph breaks; for long quotations use the blockquote element.", HtmlElementCategoryNames.InlineTextSemantics)]
public class QHtmlElement : HtmlElement
{
    public QHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
