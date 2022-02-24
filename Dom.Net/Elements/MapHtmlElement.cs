using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Map, "The <map> HTML element is used with area elements to define an image map (a clickable link area).", HtmlElementCategoryNames.ImageAndMultimedia)]
public class MapHtmlElement : HtmlElement
{
    public MapHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
