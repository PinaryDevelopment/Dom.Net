using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Fieldset, "The <fieldset> HTML element is used to group several controls as well as labels (label) within a web form.", HtmlElementCategoryNames.Forms)]
public class FieldsetHtmlElement : HtmlElement
{
    public FieldsetHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
