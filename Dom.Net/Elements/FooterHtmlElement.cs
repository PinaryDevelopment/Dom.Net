using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Footer, "The <footer> HTML element represents a footer for its nearest sectioning content or sectioning root element. A <footer> typically contains information about the author of the section, copyright data or links to related documents.", HtmlElementCategoryNames.ContentSectioning)]
public class FooterHtmlElement : HtmlElement
{
    public FooterHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
