using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.H6, "The <h1> to <h6> HTML elements represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.", HtmlElementCategoryNames.ContentSectioning)]
public class H6HtmlElement : HtmlElement
{
    public H6HtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
