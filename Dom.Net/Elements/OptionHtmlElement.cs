using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Option, "The <option> HTML element is used to define an item contained in a select, an optgroup, or a datalist element. As such, <option> can represent menu items in popups and other lists of items in an HTML document.", HtmlElementCategoryNames.Forms)]
public class OptionHtmlElement : HtmlElement
{
    public OptionHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
