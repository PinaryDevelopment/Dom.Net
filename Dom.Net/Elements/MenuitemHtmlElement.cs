using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Menuitem, "The <menuitem> HTML element represents a command that a user is able to invoke through a popup menu. This includes context menus, as well as menus that might be attached to a menu button.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class MenuitemHtmlElement : HtmlElement
{
    public MenuitemHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
