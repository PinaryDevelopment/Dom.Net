using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Doctype, "In HTML, the doctype is the required \"<!DOCTYPE html>\" preamble found at the top of all documents. Its sole purpose is to prevent a browser from switching into so-called “quirks mode” when rendering a document; that is, the \"<!DOCTYPE html>\" doctype ensures that the browser makes a best-effort attempt at following the relevant specifications, rather than using a different rendering mode that is incompatible with some specifications.", HtmlElementCategoryNames.FauxElements)]
public class DocTypeHtmlElement : HtmlElement
{
    public DocTypeHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
