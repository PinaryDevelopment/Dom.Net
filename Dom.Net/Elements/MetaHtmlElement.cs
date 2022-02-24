using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Meta, "The <meta> HTML element represents Metadata that cannot be represented by other HTML meta-related elements, like base, link, script, style or title.", HtmlElementCategoryNames.DocumentMetadata)]
public class MetaHtmlElement : HtmlElement
{
    public MetaHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
