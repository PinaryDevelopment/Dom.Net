using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Ruby, "The <ruby> HTML element represents small annotations that are rendered above, below, or next to base text, usually used for showing the pronunciation of East Asian characters. It can also be used for annotating other kinds of text, but this usage is less common.", HtmlElementCategoryNames.InlineTextSemantics)]
public class RubyHtmlElement : HtmlElement
{
    public RubyHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
