using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Select, "The <select> HTML element represents a control that provides a menu of options:", HtmlElementCategoryNames.Forms)]
public class SelectHtmlElement : HtmlElement
{
    public SelectHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
