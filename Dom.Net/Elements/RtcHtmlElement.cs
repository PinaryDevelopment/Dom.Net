using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Rtc, "The <rtc> HTML element embraces semantic annotations of characters presented in a ruby of rb elements used inside of ruby element. rb elements can have both pronunciation (rt) and semantic (rtc) annotations.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class RtcHtmlElement : HtmlElement
{
    public RtcHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
