using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Acronym, "The <acronym> HTML element allows authors to clearly indicate a sequence of characters that compose an acronym or abbreviation for a word.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class AcronymHtmlElement : HtmlElement
{
    public AcronymHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
