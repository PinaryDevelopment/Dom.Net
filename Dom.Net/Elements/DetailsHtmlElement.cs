using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Details, "The <details> HTML element creates a disclosure widget in which information is visible only when the widget is toggled into an \"open\" state. A summary or label must be provided using the summary element.", HtmlElementCategoryNames.InteractiveElements)]
public class DetailsHtmlElement : HtmlElement
{
    public DetailsHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
