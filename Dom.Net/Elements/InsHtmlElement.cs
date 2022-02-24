using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Ins, "The <ins> HTML element represents a range of text that has been added to a document. You can use the del element to similarly represent a range of text that has been deleted from the document.", HtmlElementCategoryNames.DemarcatingEdits)]
public class InsHtmlElement : HtmlElement
{
    public InsHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
