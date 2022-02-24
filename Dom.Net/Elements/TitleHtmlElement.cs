using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Title, "The <title> HTML element defines the document's title that is shown in a Browser's title bar or a page's tab. It only contains text; tags within the element are ignored.", HtmlElementCategoryNames.DocumentMetadata)]
public class TitleHtmlElement : HtmlElement
{
    public TitleHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
