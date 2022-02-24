using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Form, "The <form> HTML element represents a document section containing interactive controls for submitting information.", HtmlElementCategoryNames.Forms)]
public class FormHtmlElement : HtmlElement
{
    public FormHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
