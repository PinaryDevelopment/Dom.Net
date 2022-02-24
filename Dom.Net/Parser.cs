using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PinaryDevelopment.Dom.Net;

public static class Parser
{
    public static HtmlElement[] ParseFile(string path)
    {
        return Parse(File.ReadAllText(path));
    }

    public static HtmlElement[] Parse(string html)
    {
        return TokenizeHtml(html)
                .Select(str => ParseElement(str))
                .ToArray();
    }

    public static HtmlAttribute[] ParseAttributes(string contents)
    {
        return TokenizeAttributes(contents)
                .Select(kv => new HtmlAttribute(kv.Name, kv.Value))
                .ToArray();
    }

    private static HtmlElement ParseElement(string str)
    {
        str = str.Trim();
        var delimiter = str.IndexOf(' ');
        return HtmlElementFactory.Create(delimiter < 0 ? str : str[..delimiter], delimiter < 0 ? string.Empty : str[delimiter..]);
    }

    private static IEnumerable<(string Name, string Value)> TokenizeAttributes(string contents)
    {
        contents = contents.Trim();

        var sb = new StringBuilder();
        string name = null;
        foreach (var c in contents)
        {
            if (c == '=' || c == ' ' || c == '>')
            {
                if (sb.Length > 0)
                {
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        name = sb.ToString();
                    }
                    else
                    {
                        yield return (name, sb.ToString());
                        name = null;
                    }

                    sb.Clear();
                }
            }
            else
            {
                sb.Append(c);
            }
        }

        if (!string.IsNullOrWhiteSpace(name))
        {
            yield return (name, null);
        }
    }

    private static IEnumerable<string> TokenizeHtml(string html)
    {
        var tag = new StringBuilder();

        for (var i = 0; i < html.Length; i++)
        {
            if (html[i] == '<')
            {
                var tagString = tag.ToString();
                if (!string.IsNullOrWhiteSpace(tagString))
                {
                    yield return tagString.Trim();
                }

                tag.Clear();
                tag.Append(html[i]);
            }
            else if (html[i] == '>')
            {
                tag.Append(html[i]);
                yield return tag.ToString().Trim();

                tag.Clear();
            }
            else
            {
                tag.Append(html[i]);
            }
        }
    }
}
