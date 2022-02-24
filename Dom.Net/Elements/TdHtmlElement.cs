using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Td, "The <td> HTML element defines a cell of a table that contains data. It participates in the table model.", HtmlElementCategoryNames.TableContent)]
public class TdHtmlElement : HtmlElement
{
    public TdHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
