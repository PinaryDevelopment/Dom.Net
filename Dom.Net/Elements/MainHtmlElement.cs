using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Main, "The <main> HTML element represents the dominant content of the body of a document. The main content area consists of content that is directly related to or expands upon the central topic of a document, or the central functionality of an application.", HtmlElementCategoryNames.ContentSectioning)]
public class MainHtmlElement : HtmlElement
{
    public MainHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
