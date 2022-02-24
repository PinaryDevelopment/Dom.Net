using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Body, "The <body> HTML element represents the content of an HTML document. There can be only one <body> element in a document.", HtmlElementCategoryNames.SectioningRoot)]
public class BodyHtmlElement : HtmlElement
{
    public BodyHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
