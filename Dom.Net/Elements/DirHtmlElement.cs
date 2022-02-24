using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Dir, "The <dir> HTML element is used as a container for a directory of files and/or folders, potentially with styles and icons applied by the user agent. Do not use this obsolete element; instead, you should use the ul element for lists, including lists of files.", HtmlElementCategoryNames.ObsoleteAndDeprecatedElements)]
public class DirHtmlElement : HtmlElement
{
    public DirHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
