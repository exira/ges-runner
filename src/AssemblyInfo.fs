namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.1.23")>]
[<assembly: AssemblyFileVersionAttribute("1.1.23")>]
[<assembly: AssemblyMetadataAttribute("githash","00a2ba9598a3939336ad539adafb05936db08225")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.23"
