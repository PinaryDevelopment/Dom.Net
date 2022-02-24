using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Source, "The <source> HTML element specifies multiple media resources for the picture, the audio element, or the video element. It is an empty element, meaning that it has no content and does not have a closing tag. It is commonly used to offer the same media content in multiple file formats in order to provide compatibility with a broad range of browsers given their differing support for image file formats and media file formats.", HtmlElementCategoryNames.EmbeddedContent)]
public class SourceHtmlElement : HtmlElement
{
    public SourceHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
