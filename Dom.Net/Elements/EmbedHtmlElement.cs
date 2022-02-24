using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Embed, "The <embed> HTML element embeds external content at the specified point in the document. This content is provided by an external application or other source of interactive content such as a browser plug-in.", HtmlElementCategoryNames.EmbeddedContent)]
public class EmbedHtmlElement : HtmlElement
{
    public EmbedHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
