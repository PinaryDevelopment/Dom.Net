using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Noframes, "The <noframes> HTML element provides content to be presented in browsers that don't support (or have disabled support for) the frame element. Although most commonly-used browsers support frames, there are exceptions, including certain special-use browsers including some mobile browsers, as well as text-mode browsers.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class NoframesHtmlElement : HtmlElement
{
    public NoframesHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
