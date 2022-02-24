using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Template, "The <template> HTML element is a mechanism for holding HTML that is not to be rendered immediately when a page is loaded but may be instantiated subsequently during runtime using JavaScript.", HtmlElementCategoryNames.WebComponents)]
public class TemplateHtmlElement : HtmlElement
{
    public TemplateHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
