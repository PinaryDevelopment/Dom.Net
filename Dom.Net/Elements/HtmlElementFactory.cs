namespace PinaryDevelopment.Dom.Net.Elements;

public static class HtmlElementFactory
{
    public static HtmlElement Create(string tag/*, IEnumerable<(string Name, string Value)> attributes*/, string contents)
    {
        // TODO: look at parsing logic from previous project
        // TODO: look into readonly span
        // TODO: deal with 'faux' elements, like comments and text.
        if (tag[0] != '<')
        {
            return new TextContentFauxHtmlElement(contents);
        }
        else if (tag.StartsWith("<!--"))
        {
            return new CommentFauxHtmlElement(contents);
        }

        tag = tag[1..];
        if (tag[^1] == '>')
        {
            tag = tag[0..^1];
        }

        if (HtmlElementFactories.LookupByTagName.ContainsKey(tag))
        {
            return HtmlElementFactories.LookupByTagName[tag](Parser.ParseAttributes(contents), contents);
        }
        else
        {
            return new CustomHtmlElement(tag, string.Empty, Parser.ParseAttributes(contents), contents);
        }
    }
}
