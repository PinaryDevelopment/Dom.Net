using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Canvas, "Use the HTML <canvas> element with either the canvas scripting API or the WebGL API to draw graphics and animations.", HtmlElementCategoryNames.Scripting)]
public class CanvasHtmlElement : HtmlElement
{
    public CanvasHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
