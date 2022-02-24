using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Tfoot, "The <tfoot> HTML element defines a set of rows summarizing the columns of the table.", HtmlElementCategoryNames.TableContent)]
public class TfootHtmlElement : HtmlElement
{
    public TfootHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
