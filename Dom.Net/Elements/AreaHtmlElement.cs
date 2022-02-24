using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Area, "The <area> HTML element defines an area inside an image map that has predefined clickable areas. An image map allows geometric areas on an image to be associated with Hyperlink.", HtmlElementCategoryNames.ImageAndMultimedia)]
public class AreaHtmlElement : HtmlElement
{
    public AreaHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
