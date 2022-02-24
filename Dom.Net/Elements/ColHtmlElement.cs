using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Col, "The <col> HTML element defines a column within a table and is used for defining common semantics on all common cells. It is generally found within a colgroup element.", HtmlElementCategoryNames.TableContent)]
public class ColHtmlElement : HtmlElement
{
    public ColHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
