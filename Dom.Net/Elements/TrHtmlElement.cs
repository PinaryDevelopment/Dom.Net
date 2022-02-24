using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Tr, "The <tr> HTML element defines a row of cells in a table. The row's cells can then be established using a mix of td (data cell) and th (header cell) elements.", HtmlElementCategoryNames.TableContent)]
public class TrHtmlElement : HtmlElement
{
    public TrHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
