using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.U, "The <u> HTML element represents a span of inline text which should be rendered in a way that indicates that it has a non-textual annotation. This is rendered by default as a simple solid underline, but may be altered using CSS.", HtmlElementCategoryNames.InlineTextSemantics)]
public class UHtmlElement : HtmlElement
{
    public UHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
