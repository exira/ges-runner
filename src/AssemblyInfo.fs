namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.3.26")>]
[<assembly: AssemblyFileVersionAttribute("1.3.26")>]
[<assembly: AssemblyMetadataAttribute("githash","90e1eaa4f3902297bac9ad2ef3bd6f26450617e6")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.3.26"
