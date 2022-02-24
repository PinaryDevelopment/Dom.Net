using PinaryDevelopment.Dom.Net.Attributes;
using PinaryDevelopment.Dom.Net.Elements.Categories;
using System.Collections.Generic;
using System.Linq;

namespace PinaryDevelopment.Dom.Net.Elements;

public abstract class HtmlElement
{
    private IDictionary<string, HtmlAttribute> Attributes { get; }
    private HtmlElementMetadataAttribute Metadata { get; }

    public HtmlElementCategory Category => Metadata?.Category;
    public string Contents { get; }
    public string Description { get; private set; }
    public string Tag { get; private set; }

    public HtmlElement(HtmlAttribute[] attributes, string contents)
    {
        Attributes = attributes.ToDictionary(kv => kv.Name, kv => kv);
        Metadata = GetType().GetCustomAttributes(typeof(HtmlElementMetadataAttribute), true).Cast<HtmlElementMetadataAttribute>().FirstOrDefault();
        Contents = contents;

        Description = Metadata?.Description;
        Tag = Metadata?.Tag;
    }

    public HtmlAttribute GetAttribute(string name)
    {
        return Attributes[name];
    }

    protected void SetTag(string tag)
    {
        Tag = tag;
    }

    protected void SetDescription(string description)
    {
        Description = description;
    }
}
