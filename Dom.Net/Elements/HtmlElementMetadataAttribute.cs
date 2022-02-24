using PinaryDevelopment.Dom.Net.Elements.Categories;
using System;

namespace PinaryDevelopment.Dom.Net.Elements;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class HtmlElementMetadataAttribute : Attribute
{
    public HtmlElementCategory Category { get; }

    public string Description { get; }

    public string Tag { get; }

    public HtmlElementMetadataAttribute(string tag = null, string description = null, string categoryName = null)
    {
        Category = HtmlElementCategories.LookupByCategoryName[categoryName];
        Description = description;
        Tag = tag;
    }
}
