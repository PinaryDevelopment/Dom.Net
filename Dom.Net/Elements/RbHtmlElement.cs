using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Rb, "The <rb> HTML element is used to delimit the base text component of a  ruby annotation, i.e. the text that is being annotated. One <rb> element should wrap each separate atomic segment of the base text.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class RbHtmlElement : HtmlElement
{
    public RbHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
