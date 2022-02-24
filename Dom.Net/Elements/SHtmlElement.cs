using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.S, "The <s> HTML element renders text with a strikethrough, or a line through it. Use the <s> element to represent things that are no longer relevant or no longer accurate. However, <s> is not appropriate when indicating document edits; for that, use the del and ins elements, as appropriate.", HtmlElementCategoryNames.InlineTextSemantics)]
public class SHtmlElement : HtmlElement
{
    public SHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
