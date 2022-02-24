using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Cite, "The <cite> HTML element is used to describe a reference to a cited creative work, and must include the title of that work. The reference may be in an abbreviated form according to context-appropriate conventions related to citation metadata.", HtmlElementCategoryNames.InlineTextSemantics)]
public class CiteHtmlElement : HtmlElement
{
    public CiteHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
