using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Datalist, "The <datalist> HTML element contains a set of option elements that represent the permissible or recommended options available to choose from within other controls.", HtmlElementCategoryNames.Forms)]
public class DatalistHtmlElement : HtmlElement
{
    public DatalistHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
