using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Object, "The <object> HTML element represents an external resource, which can be treated as an image, a nested browsing context, or a resource to be handled by a plugin.", HtmlElementCategoryNames.EmbeddedContent)]
public class ObjectHtmlElement : HtmlElement
{
    public ObjectHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
