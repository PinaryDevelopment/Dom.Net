using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Strike, "The <strike> HTML element places a strikethrough (horizontal line) over text.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class StrikeHtmlElement : HtmlElement
{
    public StrikeHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
