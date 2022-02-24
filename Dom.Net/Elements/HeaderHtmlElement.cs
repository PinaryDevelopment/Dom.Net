using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Header, "The <header> HTML element represents introductory content, typically a group of introductory or navigational aids. It may contain some heading elements but also a logo, a search form, an author name, and other elements.", HtmlElementCategoryNames.ContentSectioning)]
public class HeaderHtmlElement : HtmlElement
{
    public HeaderHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
