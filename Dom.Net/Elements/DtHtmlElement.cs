using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Dt, "The <dt> HTML element specifies a term in a description or definition list, and as such must be used inside a dl element. It is usually followed by a dd element; however, multiple <dt> elements in a row indicate several terms that are all defined by the immediate next dd element.", HtmlElementCategoryNames.TextContent)]
public class DtHtmlElement : HtmlElement
{
    public DtHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
