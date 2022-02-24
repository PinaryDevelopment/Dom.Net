using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Hr, "The <hr> HTML element represents a thematic break between paragraph-level elements: for example, a change of scene in a story, or a shift of topic within a section.", HtmlElementCategoryNames.TextContent)]
public class HrHtmlElement : HtmlElement
{
    public HrHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
