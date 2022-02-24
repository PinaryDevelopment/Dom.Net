using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Address, "The <address> HTML element indicates that the enclosed HTML provides contact information for a person or people, or for an organization.", HtmlElementCategoryNames.ContentSectioning)]
public class AddressHtmlElement : HtmlElement
{
    public AddressHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
