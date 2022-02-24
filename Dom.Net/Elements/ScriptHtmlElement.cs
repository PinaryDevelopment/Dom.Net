using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Script, "The <script> HTML element is used to embed executable code or data; this is typically used to embed or refer to JavaScript code. The <script> element can also be used with other languages, such as WebGL's GLSL shader programming language and JSON.", HtmlElementCategoryNames.Scripting)]
public class ScriptHtmlElement : HtmlElement
{
    public ScriptHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
