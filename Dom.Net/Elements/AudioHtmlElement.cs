using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Audio, "The <audio> HTML element is used to embed sound content in documents. It may contain one or more audio sources, represented using the src attribute or the source element: the browser will choose the most suitable one. It can also be the destination for streamed media, using a MediaStream.", HtmlElementCategoryNames.ImageAndMultimedia)]
public class AudioHtmlElement : HtmlElement
{
    public AudioHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
