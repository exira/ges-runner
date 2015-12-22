namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.21")>]
[<assembly: AssemblyFileVersionAttribute("1.0.21")>]
[<assembly: AssemblyMetadataAttribute("githash","c0a399d2af5186272d5c4f9d252729fea4ab0c7a")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.21"
