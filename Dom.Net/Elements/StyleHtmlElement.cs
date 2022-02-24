using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Style, "The <style> HTML element contains style information for a document, or part of a document. It contains CSS, which is applied to the contents of the document containing the <style> element.", HtmlElementCategoryNames.DocumentMetadata)]
public class StyleHtmlElement : HtmlElement
{
    public StyleHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
