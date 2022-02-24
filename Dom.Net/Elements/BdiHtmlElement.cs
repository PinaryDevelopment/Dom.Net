using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Bdi, "The <bdi> HTML element tells the browser's bidirectional algorithm to treat the text it contains in isolation from its surrounding text. It's particularly useful when a website dynamically inserts some text and doesn't know the directionality of the text being inserted.", HtmlElementCategoryNames.InlineTextSemantics)]
public class BdiHtmlElement : HtmlElement
{
    public BdiHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
