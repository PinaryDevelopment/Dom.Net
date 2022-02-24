using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Rp, "The <rp> HTML element is used to provide fall-back parentheses for browsers that do not support display of ruby annotations using the ruby element. One <rp> element should enclose each of the opening and closing parentheses that wrap the rt element that contains the annotation's text.", HtmlElementCategoryNames.InlineTextSemantics)]
public class RpHtmlElement : HtmlElement
{
    public RpHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
