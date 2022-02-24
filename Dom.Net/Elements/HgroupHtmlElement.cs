using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Hgroup, "The <hgroup> HTML element represents a multi-level heading for a section of a document. It groups a set of <h1>–<h6> elements.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class HgroupHtmlElement : HtmlElement
{
    public HgroupHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
