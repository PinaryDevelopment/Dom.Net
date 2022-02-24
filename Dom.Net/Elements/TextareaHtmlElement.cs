using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Textarea, "The <textarea> HTML element represents a multi-line plain-text editing control, useful when you want to allow users to enter a sizeable amount of free-form text, for example a comment on a review or feedback form.", HtmlElementCategoryNames.Forms)]
public class TextareaHtmlElement : HtmlElement
{
    public TextareaHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
