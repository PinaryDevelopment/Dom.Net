using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Abbr, "The <abbr> HTML element represents an abbreviation or acronym; the optional title attribute can provide an expansion or description for the abbreviation. If present, title must contain this full description and nothing else.", HtmlElementCategoryNames.InlineTextSemantics)]
public class AbbrHtmlElement : HtmlElement
{
    public AbbrHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
