using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Tbody, "The <tbody> HTML element encapsulates a set of table rows (tr elements), indicating that they comprise the body of the table (table).", HtmlElementCategoryNames.TableContent)]
public class TbodyHtmlElement : HtmlElement
{
    public TbodyHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
