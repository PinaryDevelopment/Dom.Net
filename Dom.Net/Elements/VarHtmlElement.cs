using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Var, "The <var> HTML element represents the name of a variable in a mathematical expression or a programming context. It's typically presented using an italicized version of the current typeface, although that behavior is browser-dependent.", HtmlElementCategoryNames.InlineTextSemantics)]
public class VarHtmlElement : HtmlElement
{
    public VarHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
