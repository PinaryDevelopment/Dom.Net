using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Base, "The <base> HTML element specifies the base URL to use for all relative URLs in a document. There can be only one <base> element in a document.", HtmlElementCategoryNames.DocumentMetadata)]
public class BaseHtmlElement : HtmlElement
{
    public BaseHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
