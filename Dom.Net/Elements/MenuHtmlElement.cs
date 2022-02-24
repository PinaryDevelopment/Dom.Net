using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Menu, "The <menu> HTML element is a semantic alternative to ul. It represents an unordered list of items (represented by li elements), each of these represent a link or other command that the user can activate.", HtmlElementCategoryNames.InteractiveElements)]
public class MenuHtmlElement : HtmlElement
{
    public MenuHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
