using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Del, "The <del> HTML element represents a range of text that has been deleted from a document. This can be used when rendering \"track changes\" or source code diff information, for example. The ins element can be used for the opposite purpose: to indicate text that has been added to the document.", HtmlElementCategoryNames.DemarcatingEdits)]
public class DelHtmlElement : HtmlElement
{
    public DelHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
