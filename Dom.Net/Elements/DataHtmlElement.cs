using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Data, "The <data> HTML element links a given piece of content with a machine-readable translation. If the content is time- or date-related, the time element must be used.", HtmlElementCategoryNames.InlineTextSemantics)]
public class DataHtmlElement : HtmlElement
{
    public DataHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
