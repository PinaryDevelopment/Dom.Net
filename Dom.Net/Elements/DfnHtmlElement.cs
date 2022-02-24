using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Dfn, "The <dfn> HTML element is used to indicate the term being defined within the context of a definition phrase or sentence. The p element, the dt/dd pairing, or the section element which is the nearest ancestor of the <dfn> is considered to be the definition of the term.", HtmlElementCategoryNames.InlineTextSemantics)]
public class DfnHtmlElement : HtmlElement
{
    public DfnHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
