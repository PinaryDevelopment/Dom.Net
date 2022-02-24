using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Output, "The <output> HTML element is a container element into which a site or app can inject the results of a calculation or the outcome of a user action.", HtmlElementCategoryNames.Forms)]
public class OutputHtmlElement : HtmlElement
{
    public OutputHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
