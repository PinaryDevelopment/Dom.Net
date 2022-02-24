using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Aside, "The <aside> HTML element represents a portion of a document whose content is only indirectly related to the document's main content. Asides are frequently presented as sidebars or call-out boxes.", HtmlElementCategoryNames.ContentSectioning)]
public class AsideHtmlElement : HtmlElement
{
    public AsideHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
