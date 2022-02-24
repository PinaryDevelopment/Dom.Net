using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(categoryName: HtmlElementCategoryNames.CustomElements)]
public class CustomHtmlElement : HtmlElement
{
    public CustomHtmlElement(string tag, string description, HtmlAttribute[] attributes, string contents) : base(attributes, contents)
    {
        SetTag(tag);
        SetDescription(description);
    }
}
