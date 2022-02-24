using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Samp, "The <samp> HTML element is used to enclose inline text which represents sample (or quoted) output from a computer program. Its contents are typically rendered using the browser's default monospaced font (such as Courier or Lucida Console).", HtmlElementCategoryNames.InlineTextSemantics)]
public class SampHtmlElement : HtmlElement
{
    public SampHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
