using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Slot, "The <slot> HTML element—part of the Web Components technology suite—is a placeholder inside a web component that you can fill with your own markup, which lets you create separate DOM trees and present them together.", HtmlElementCategoryNames.WebComponents)]
public class SlotHtmlElement : HtmlElement
{
    public SlotHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
