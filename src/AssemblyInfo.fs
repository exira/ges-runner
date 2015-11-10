namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.11")>]
[<assembly: AssemblyFileVersionAttribute("1.0.11")>]
[<assembly: AssemblyMetadataAttribute("githash","3f767e63502cc6465c5087c68906c320257f2c86")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.11"
