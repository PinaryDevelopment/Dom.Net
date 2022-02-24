using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Section, "The <section> HTML element represents a generic standalone section of a document, which doesn't have a more specific semantic element to represent it. Sections should always have a heading, with very few exceptions.", HtmlElementCategoryNames.ContentSectioning)]
public class SectionHtmlElement : HtmlElement
{
    public SectionHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
