using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Colgroup, "The <colgroup> HTML element defines a group of columns within a table.", HtmlElementCategoryNames.TableContent)]
public class ColgroupHtmlElement : HtmlElement
{
    public ColgroupHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
