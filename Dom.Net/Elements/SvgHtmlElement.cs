using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Svg, "The svg element is a container that defines a new coordinate system and viewport. It is used as the outermost element of SVG documents, but it can also be used to embed an SVG fragment inside an SVG or HTML document.", HtmlElementCategoryNames.SvgAndMathMl)]
public class SvgHtmlElement : HtmlElement
{
    public SvgHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
