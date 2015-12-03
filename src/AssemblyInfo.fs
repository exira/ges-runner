namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.19")>]
[<assembly: AssemblyFileVersionAttribute("1.0.19")>]
[<assembly: AssemblyMetadataAttribute("githash","be93407655568480b12f6fb883b7be2eef47527d")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.19"
