using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Time, "The <time> HTML element represents a specific period in time. It may include the datetime attribute to translate dates into machine-readable format, allowing for better search engine results or custom features such as reminders.", HtmlElementCategoryNames.InlineTextSemantics)]
public class TimeHtmlElement : HtmlElement
{
    public TimeHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
