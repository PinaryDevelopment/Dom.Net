using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Math, "The top-level element in MathML is <math>. Every valid MathML instance must be wrapped in <math> tags. In addition you must not nest a second <math> element in another, but you can have an arbitrary number of other child elements in it.", HtmlElementCategoryNames.SvgAndMathMl)]
public class MathHtmlElement : HtmlElement
{
    public MathHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
