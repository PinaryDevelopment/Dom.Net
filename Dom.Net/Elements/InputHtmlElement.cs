﻿using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Input, "The <input> HTML element is used to create interactive controls for web-based forms in order to accept data from the user; a wide variety of types of input data and control widgets are available, depending on the device and user agent. The <input> element is one of the most powerful and complex in all of HTML due to the sheer number of combinations of input types and attributes.", HtmlElementCategoryNames.Forms)]
public class InputHtmlElement : HtmlElement
{
    public InputHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
