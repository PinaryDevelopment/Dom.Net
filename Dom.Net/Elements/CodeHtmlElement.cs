using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Code, "The <code> HTML element displays its contents styled in a fashion intended to indicate that the text is a short fragment of computer code. By default, the content text is displayed using the user agent default monospace font.", HtmlElementCategoryNames.InlineTextSemantics)]
public class CodeHtmlElement : HtmlElement
{
    public CodeHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
