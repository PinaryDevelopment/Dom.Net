using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Em, "The <em> HTML element marks text that has stress emphasis. The <em> element can be nested, with each level of nesting indicating a greater degree of emphasis.", HtmlElementCategoryNames.InlineTextSemantics)]
public class EmHtmlElement : HtmlElement
{
    public EmHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
