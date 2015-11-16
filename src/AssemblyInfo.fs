namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.15")>]
[<assembly: AssemblyFileVersionAttribute("1.0.15")>]
[<assembly: AssemblyMetadataAttribute("githash","9e4ae68ea023c89a7e125d850131f30be87c5933")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.15"
