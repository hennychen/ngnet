using Furion;
using System.Reflection;

namespace ngnet.Web.Entry;

public class SingleFilePublish : ISingleFilePublish
{
    public Assembly[] IncludeAssemblies()
    {
        return Array.Empty<Assembly>();
    }

    public string[] IncludeAssemblyNames()
    {
        return new[]
        {
            "ngnet.Application",
            "ngnet.Core",
            "ngnet.EntityFramework.Core",
            "ngnet.Web.Core"
        };
    }
}