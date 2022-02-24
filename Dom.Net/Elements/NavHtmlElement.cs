using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Nav, "The <nav> HTML element represents a section of a page whose purpose is to provide navigation links, either within the current document or to other documents. Common examples of navigation sections are menus, tables of contents, and indexes.", HtmlElementCategoryNames.ContentSectioning)]
public class NavHtmlElement : HtmlElement
{
    public NavHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
