namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("0.1.8")>]
[<assembly: AssemblyFileVersionAttribute("0.1.8")>]
[<assembly: AssemblyMetadataAttribute("githash","98ecb6aab46c9b7e0849792252ed24cae8e2ebe6")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.8"
