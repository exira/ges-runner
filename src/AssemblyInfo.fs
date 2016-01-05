namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.3.28")>]
[<assembly: AssemblyFileVersionAttribute("1.3.28")>]
[<assembly: AssemblyMetadataAttribute("githash","d2d9f9e5a9846fef74b8799d0debabb68d7077cc")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.3.28"
