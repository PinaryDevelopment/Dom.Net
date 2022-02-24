using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Dialog, "The <dialog> HTML element represents a dialog box or other interactive component, such as a dismissible alert, inspector, or subwindow.", HtmlElementCategoryNames.InteractiveElements)]
public class DialogHtmlElement : HtmlElement
{
    public DialogHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
