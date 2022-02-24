using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.A, "The <a> HTML element (or anchor element), with its href attribute, creates a hyperlink to web pages, files, email addresses, locations in the same page, or anything else a URL can address.", HtmlElementCategoryNames.InlineTextSemantics)]
public class AHtmlElement : HtmlElement
{
    public AHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
