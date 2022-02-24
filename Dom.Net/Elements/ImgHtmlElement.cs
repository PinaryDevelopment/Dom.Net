using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Img, "The <img> HTML element embeds an image into the document.", HtmlElementCategoryNames.ImageAndMultimedia)]
public class ImgHtmlElement : HtmlElement
{
    public ImgHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
