using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Caption, "The <caption> HTML element specifies the caption (or title) of a table.", HtmlElementCategoryNames.TableContent)]
public class CaptionHtmlElement : HtmlElement
{
    public CaptionHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
