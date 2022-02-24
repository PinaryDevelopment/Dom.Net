using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinaryDevelopment.Dom.Net.Elements;
using System.Linq;

namespace PinaryDevelopment.Dom.Net.Tests.Unit;

[TestClass]
public class DefaultHtml
{
    private readonly HtmlElement[] ParsedElements;

    public DefaultHtml()
    {
        ParsedElements = Parser.ParseFile(Utilities.GetTestHtmlFilePath("default.html"));
    }

    [TestMethod("1. Parsed elements contain doctype element")]
    public void HasDoctypeTag()
    {
        Assert.IsNotNull(ParsedElements.Single(ele => ele.GetType() == typeof(DocTypeHtmlElement)));
    }

    [TestMethod("1a. Parsed doctype element empty attribute")]
    public void HasEmptyAttribute()
    {
        var doctypeElement = ParsedElements.Single(ele => ele.GetType() == typeof(DocTypeHtmlElement));
        Assert.IsNotNull(doctypeElement.GetAttribute("html"));
    }

    [TestMethod("2. Parsed elements contain html element")]
    public void HasHtmlTag()
    {
        Assert.IsNotNull(ParsedElements.Single(ele => ele.GetType() == typeof(HtmlHtmlElement)));
    }

    [TestMethod("3. Parsed elements contain head element")]
    public void HasHeadTag()
    {
        Assert.IsNotNull(ParsedElements.Single(ele => ele.GetType() == typeof(HeadHtmlElement)));
    }

    [TestMethod("4. Parsed elements contain body element")]
    public void HasBodyTag()
    {
        Assert.IsNotNull(ParsedElements.Single(ele => ele.GetType() == typeof(BodyHtmlElement)));
    }
}
