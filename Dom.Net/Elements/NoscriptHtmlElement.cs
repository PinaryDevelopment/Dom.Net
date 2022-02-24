using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Noscript, "The <noscript> HTML element defines a section of HTML to be inserted if a script type on the page is unsupported or if scripting is currently turned off in the browser.", HtmlElementCategoryNames.Scripting)]
public class NoscriptHtmlElement : HtmlElement
{
    public NoscriptHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
