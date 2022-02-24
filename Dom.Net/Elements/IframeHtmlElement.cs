using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Iframe, "The <iframe> HTML element represents a nested browsing context, embedding another HTML page into the current one.", HtmlElementCategoryNames.EmbeddedContent)]
public class IframeHtmlElement : HtmlElement
{
    public IframeHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
