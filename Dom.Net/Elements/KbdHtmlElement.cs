using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Kbd, "The <kbd> HTML element represents a span of inline text denoting textual user input from a keyboard, voice input, or any other text entry device. By convention, the user agent defaults to rendering the contents of a <kbd> element using its default monospace font, although this is not mandated by the HTML standard.", HtmlElementCategoryNames.InlineTextSemantics)]
public class KbdHtmlElement : HtmlElement
{
    public KbdHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
