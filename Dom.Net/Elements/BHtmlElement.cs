using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.B, "The <b> HTML element is used to draw the reader's attention to the element's contents, which are not otherwise granted special importance. This was formerly known as the Boldface element, and most browsers still draw the text in boldface. However, you should not use <b> for styling text; instead, you should use the CSS font-weight property to create boldface text, or the strong element to indicate that text is of special importance.", HtmlElementCategoryNames.InlineTextSemantics)]
public class BHtmlElement : HtmlElement
{
    public BHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
