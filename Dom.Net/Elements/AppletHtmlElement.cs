using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Applet, "The obsolete HTML Applet Element (<applet>) embeds a Java applet into the document; this element has been deprecated in favor of object.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class AppletHtmlElement : HtmlElement
{
    public AppletHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
