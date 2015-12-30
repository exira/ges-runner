namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.3.0")>]
[<assembly: AssemblyFileVersionAttribute("1.3.0")>]
[<assembly: AssemblyMetadataAttribute("githash","39769a710fd379678d7913356c1b091de0087b1e")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.3.0"
