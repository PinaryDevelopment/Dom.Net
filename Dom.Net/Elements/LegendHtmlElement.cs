using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Legend, "The <legend> HTML element represents a caption for the content of its parent fieldset.", HtmlElementCategoryNames.Forms)]
public class LegendHtmlElement : HtmlElement
{
    public LegendHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
