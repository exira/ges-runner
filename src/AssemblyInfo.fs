namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.13")>]
[<assembly: AssemblyFileVersionAttribute("1.0.13")>]
[<assembly: AssemblyMetadataAttribute("githash","d885b613b3e1cf1c742d1d4abf164d0079992f37")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.13"
