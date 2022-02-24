using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Noembed, "The <noembed> HTML element is an obsolete, non-standard way to provide alternative, or \"fallback\", content for browsers that do not support the embed element or do not support the type of embedded content an author wishes to use. This element was deprecated in HTML 4.01 and above in favor of placing fallback content between the opening and closing tags of an object element.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class NoembedHtmlElement : HtmlElement
{
    public NoembedHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
