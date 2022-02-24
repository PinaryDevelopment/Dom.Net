using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Mark, "The <mark> HTML element represents text which is marked or highlighted for reference or notation purposes, due to the marked passage's relevance or importance in the enclosing context.", HtmlElementCategoryNames.InlineTextSemantics)]
public class MarkHtmlElement : HtmlElement
{
    public MarkHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
