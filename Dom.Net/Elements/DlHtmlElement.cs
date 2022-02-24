using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Dl, "The <dl> HTML element represents a description list. The element encloses a list of groups of terms (specified using the dt element) and descriptions (provided by dd elements). Common uses for this element are to implement a glossary or to display metadata (a list of key-value pairs).", HtmlElementCategoryNames.TextContent)]
public class DlHtmlElement : HtmlElement
{
    public DlHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
