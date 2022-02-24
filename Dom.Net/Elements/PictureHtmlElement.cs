using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Picture, "The <picture> HTML element contains zero or more source elements and one img element to offer alternative versions of an image for different display/device scenarios.", HtmlElementCategoryNames.EmbeddedContent)]
public class PictureHtmlElement : HtmlElement
{
    public PictureHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
