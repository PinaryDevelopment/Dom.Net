using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Blockquote, "The <blockquote> HTML element indicates that the enclosed text is an extended quotation. Usually, this is rendered visually by indentation (see Notes for how to change it). A URL for the source of the quotation may be given using the cite attribute, while a text representation of the source can be given using the cite element.", HtmlElementCategoryNames.TextContent)]
public class BlockquoteHtmlElement : HtmlElement
{
    public BlockquoteHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
