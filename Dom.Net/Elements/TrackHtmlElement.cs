using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;

namespace PinaryDevelopment.Dom.Net.Elements;

[HtmlElementMetadata(HtmlElementTags.Track, "The <track> HTML element is used as a child of the media elements, audio and video. It lets you specify timed text tracks (or time-based data), for example to automatically handle subtitles. The tracks are formatted in WebVTT format (.vtt files) — Web Video Text Tracks.", HtmlElementCategoryNames.ImageAndMultimedia)]
public class TrackHtmlElement : HtmlElement
{
    public TrackHtmlElement(HtmlAttribute[] attributes, string contents) : base(attributes, contents) { }
}
