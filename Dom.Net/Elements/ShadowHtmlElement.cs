using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Shadow, "The <shadow> HTML element—an obsolete part of the Web Components technology suite—was intended to be used as a shadow DOM insertion point. You might have used it if you have created multiple shadow roots under a shadow host. It is not useful in ordinary HTML.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class ShadowHtmlElement : HtmlElement
{
    public ShadowHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
