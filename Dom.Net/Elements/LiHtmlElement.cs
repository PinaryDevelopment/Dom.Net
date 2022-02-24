using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Li, "The <li> HTML element is used to represent an item in a list. It must be contained in a parent element: an ordered list (ol), an unordered list (ul), or a menu (menu). In menus and unordered lists, list items are usually displayed using bullet points. In ordered lists, they are usually displayed with an ascending counter on the left, such as a number or letter.", HtmlElementCategoryNames.TextContent)]
public class LiHtmlElement : HtmlElement
{
    public LiHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
