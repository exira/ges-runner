namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("0.1.10")>]
[<assembly: AssemblyFileVersionAttribute("0.1.10")>]
[<assembly: AssemblyMetadataAttribute("githash","29025a4ee21aaa764209db473e3af7a86711277f")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.10"
