using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Head, "The <head> HTML element contains machine-readable information (metadata) about the document, like its title, scripts, and style sheets.", HtmlElementCategoryNames.DocumentMetadata)]
public class HeadHtmlElement : HtmlElement
{
    public HeadHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
