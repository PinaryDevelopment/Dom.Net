namespace PinaryDevelopment.Dom.Net.Elements.Categories;

public class FauxElementsHtmlElementCategory : HtmlElementCategory
{
    public FauxElementsHtmlElementCategory() : base(HtmlElementCategoryNames.FauxElements, "These elements are parts of the DOM that should be represented, but aren't a part of the spec, such as comments and text.") { }
}
