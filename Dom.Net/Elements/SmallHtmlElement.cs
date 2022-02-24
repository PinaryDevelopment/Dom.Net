using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Small, "The <small> HTML element represents side-comments and small print, like copyright and legal text, independent of its styled presentation. By default, it renders text within it one font-size smaller, such as from small to x-small.", HtmlElementCategoryNames.InlineTextSemantics)]
public class SmallHtmlElement : HtmlElement
{
    public SmallHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
