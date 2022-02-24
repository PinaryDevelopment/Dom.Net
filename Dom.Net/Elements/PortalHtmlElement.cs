using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Portal, "The <portal> HTML element enables the embedding of another HTML page into the current one for the purposes of allowing smoother navigation into new pages.", HtmlElementCategoryNames.EmbeddedContent)]
public class PortalHtmlElement : HtmlElement
{
    public PortalHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
