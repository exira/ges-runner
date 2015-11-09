namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("0.1.5")>]
[<assembly: AssemblyFileVersionAttribute("0.1.5")>]
[<assembly: AssemblyMetadataAttribute("githash","599b402b9ac8c40c48d799e8c51352da3f2af426")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.5"
