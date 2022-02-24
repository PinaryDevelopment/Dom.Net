using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Optgroup, "The <optgroup> HTML element creates a grouping of options within a select element.", HtmlElementCategoryNames.Forms)]
public class OptgroupHtmlElement : HtmlElement
{
    public OptgroupHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
