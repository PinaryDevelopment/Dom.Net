using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Br, "The <br> HTML element produces a line break in text (carriage-return). It is useful for writing a poem or an address, where the division of lines is significant.", HtmlElementCategoryNames.InlineTextSemantics)]
public class BrHtmlElement : HtmlElement
{
    public BrHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
