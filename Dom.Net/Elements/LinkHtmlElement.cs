using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Link, "The <link> HTML element specifies relationships between the current document and an external resource. This element is most commonly used to link to CSS, but is also used to establish site icons (both \"favicon\" style icons and icons for the home screen and apps on mobile devices) among other things.", HtmlElementCategoryNames.DocumentMetadata)]
public class LinkHtmlElement : HtmlElement
{
    public LinkHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
