using System.Collections.Generic;

namespace PinaryDevelopment.Dom.Net.Elements.Categories;

public static class HtmlElementCategories
{
    public static IDictionary<string, HtmlElementCategory> LookupByCategoryName = new Dictionary<string, HtmlElementCategory>
    {
        { HtmlElementCategoryNames.MainRoot, new MainRootHtmlElementCategory() },
        { HtmlElementCategoryNames.DocumentMetadata, new DocumentMetadataHtmlElementCategory() },
        { HtmlElementCategoryNames.SectioningRoot, new SectioningRootHtmlElementCategory() },
        { HtmlElementCategoryNames.ContentSectioning, new ContentSectioningHtmlElementCategory() },
        { HtmlElementCategoryNames.TextContent, new TextContentHtmlElementCategory() },
        { HtmlElementCategoryNames.InlineTextSemantics, new InlineTextSemanticsHtmlElementCategory() },
        { HtmlElementCategoryNames.ImageAndMultimedia, new ImageAndMultimediaHtmlElementCategory() },
        { HtmlElementCategoryNames.EmbeddedContent, new EmbeddedContentHtmlElementCategory() },
        { HtmlElementCategoryNames.SvgAndMathMl, new SvgAndMathMlHtmlElementCategory() },
        { HtmlElementCategoryNames.Scripting, new ScriptingHtmlElementCategory() },
        { HtmlElementCategoryNames.DemarcatingEdits, new DemarcatingEditsHtmlElementCategory() },
        { HtmlElementCategoryNames.TableContent, new TableContentHtmlElementCategory() },
        { HtmlElementCategoryNames.Forms, new FormsHtmlElementCategory() },
        { HtmlElementCategoryNames.InteractiveElements, new InteractiveElementsHtmlElementCategory() },
        { HtmlElementCategoryNames.WebComponents, new WebComponentsHtmlElementCategory() },
        { HtmlElementCategoryNames.ObsoleteAndDeprecatedElements, new ObsoleteAndDeprecatedElementsHtmlElementCategory() },
        { HtmlElementCategoryNames.CustomElements, new CustomElementsHtmlElementCategory() },
        { HtmlElementCategoryNames.FauxElements, new FauxElementsHtmlElementCategory() },
    };
}
