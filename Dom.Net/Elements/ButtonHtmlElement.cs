using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Button, "The <button> HTML element represents a clickable button, used to submit forms or anywhere in a document for accessible, standard button functionality.", HtmlElementCategoryNames.Forms)]
public class ButtonHtmlElement : HtmlElement
{
    public ButtonHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
