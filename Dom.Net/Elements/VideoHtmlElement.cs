using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Video, "The <video> HTML element embeds a media player which supports video playback into the document. You can use <video> for audio content as well, but the audio element may provide a more appropriate user experience.", HtmlElementCategoryNames.ImageAndMultimedia)]
public class VideoHtmlElement : HtmlElement
{
    public VideoHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
