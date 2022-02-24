using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Content, "The <content> HTML element—an obsolete part of the Web Components suite of technologies—was used inside of Shadow DOM as an insertion point, and wasn't meant to be used in ordinary HTML. It has now been replaced by the slot element, which creates a point in the DOM at which a shadow DOM can be inserted.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class ContentHtmlElement : HtmlElement
{
    public ContentHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
