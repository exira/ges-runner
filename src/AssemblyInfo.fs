namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.20")>]
[<assembly: AssemblyFileVersionAttribute("1.0.20")>]
[<assembly: AssemblyMetadataAttribute("githash","44dc4492e964b058742777386d951789aae7bb64")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.20"
