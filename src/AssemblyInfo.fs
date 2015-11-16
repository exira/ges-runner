namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.18")>]
[<assembly: AssemblyFileVersionAttribute("1.0.18")>]
[<assembly: AssemblyMetadataAttribute("githash","4c7cd9aa63d43b0fb3d1d79263732cf0b6a9a8bb")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.18"
