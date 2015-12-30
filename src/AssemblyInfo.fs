namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.3.27")>]
[<assembly: AssemblyFileVersionAttribute("1.3.27")>]
[<assembly: AssemblyMetadataAttribute("githash","54a316d2d3cf5be9b5db7948a209a6bb9c04ece2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.3.27"
