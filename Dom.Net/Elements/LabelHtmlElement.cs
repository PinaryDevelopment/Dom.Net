using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Label, "The <label> HTML element represents a caption for an item in a user interface.", HtmlElementCategoryNames.Forms)]
public class LabelHtmlElement : HtmlElement
{
    public LabelHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
