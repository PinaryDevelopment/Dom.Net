using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.H1, "The <h1> to <h6> HTML elements represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.", HtmlElementCategoryNames.ContentSectioning)]
public class H1HtmlElement : HtmlElement
{
    public H1HtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
