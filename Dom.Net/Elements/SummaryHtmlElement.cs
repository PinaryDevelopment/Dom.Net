using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Summary, "The <summary> HTML element specifies a summary, caption, or legend for a details element's disclosure box. Clicking the <summary> element toggles the state of the parent <details> element open and closed.", HtmlElementCategoryNames.InteractiveElements)]
public class SummaryHtmlElement : HtmlElement
{
    public SummaryHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
