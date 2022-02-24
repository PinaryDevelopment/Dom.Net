using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Param, "The <param> HTML element defines parameters for an object element.", HtmlElementCategoryNames.EmbeddedContent)]
public class ParamHtmlElement : HtmlElement
{
    public ParamHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
