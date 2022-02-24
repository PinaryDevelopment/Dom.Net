using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Meter, "The <meter> HTML element represents either a scalar value within a known range or a fractional value.", HtmlElementCategoryNames.Forms)]
public class MeterHtmlElement : HtmlElement
{
    public MeterHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
