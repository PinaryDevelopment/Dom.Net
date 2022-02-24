namespace PinaryDevelopment.Dom.Net.Elements.Categories;

public abstract class HtmlElementCategory
{
    public string Category { get; }
    public string Description { get; }

    public HtmlElementCategory(string category, string description)
    {
        Category = category;
        Description = description;
    }
}
