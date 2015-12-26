namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.1.22")>]
[<assembly: AssemblyFileVersionAttribute("1.1.22")>]
[<assembly: AssemblyMetadataAttribute("githash","34df1161dd073c3f23f4101c25c9bdc23ec24a83")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.22"
