using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Tt, "The <tt> HTML element creates inline text which is presented using the user agent default monospace font face. This element was created for the purpose of rendering text as it would be displayed on a fixed-width display such as a teletype, text-only screen, or line printer.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class TtHtmlElement : HtmlElement
{
    public TtHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
