namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.14")>]
[<assembly: AssemblyFileVersionAttribute("1.0.14")>]
[<assembly: AssemblyMetadataAttribute("githash","da63bdf87ac97cdc0f964255702fe306949bbc0b")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.14"
