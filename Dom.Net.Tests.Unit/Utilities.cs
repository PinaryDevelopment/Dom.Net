using System.IO;
using System.Reflection;

namespace PinaryDevelopment.Dom.Net.Tests.Unit;

public static class Utilities
{
    public static string GetTestHtmlFilePath(string filename)
    {
        return Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    filename
                );
    }
}
