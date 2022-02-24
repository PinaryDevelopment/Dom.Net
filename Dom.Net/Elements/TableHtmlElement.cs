using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Table, "The <table> HTML element represents tabular data — that is, information presented in a two-dimensional table comprised of rows and columns of cells containing data.", HtmlElementCategoryNames.TableContent)]
public class TableHtmlElement : HtmlElement
{
    public TableHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
