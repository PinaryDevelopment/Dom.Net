using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Thead, "The <thead> HTML element defines a set of rows defining the head of the columns of the table.", HtmlElementCategoryNames.TableContent)]
public class TheadHtmlElement : HtmlElement
{
    public TheadHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
