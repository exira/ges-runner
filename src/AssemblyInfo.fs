namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("0.1.6")>]
[<assembly: AssemblyFileVersionAttribute("0.1.6")>]
[<assembly: AssemblyMetadataAttribute("githash","28770ca887e77dd450b633f21cdd883c6d399442")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.6"
