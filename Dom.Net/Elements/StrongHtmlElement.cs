using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Strong, "The <strong> HTML element indicates that its contents have strong importance, seriousness, or urgency. Browsers typically render the contents in bold type.", HtmlElementCategoryNames.InlineTextSemantics)]
public class StrongHtmlElement : HtmlElement
{
    public StrongHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
