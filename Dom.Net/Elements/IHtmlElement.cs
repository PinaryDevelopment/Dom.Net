using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.I, "The <i> HTML element represents a range of text that is set off from the normal text for some reason, such as idiomatic text, technical terms, taxonomical designations, among others. Historically, these have been presented using italicized type, which is the original source of the <i> naming of this element.", HtmlElementCategoryNames.InlineTextSemantics)]
public class IHtmlElement : HtmlElement
{
    public IHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
