using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Th, "The <th> HTML element defines a cell as header of a group of table cells. The exact nature of this group is defined by the scope and headers attributes.", HtmlElementCategoryNames.TableContent)]
public class ThHtmlElement : HtmlElement
{
    public ThHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
