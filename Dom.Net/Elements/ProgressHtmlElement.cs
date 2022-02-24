using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Progress, "The <progress> HTML element displays an indicator showing the completion progress of a task, typically displayed as a progress bar.", HtmlElementCategoryNames.Forms)]
public class ProgressHtmlElement : HtmlElement
{
    public ProgressHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
