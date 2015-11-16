namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.16")>]
[<assembly: AssemblyFileVersionAttribute("1.0.16")>]
[<assembly: AssemblyMetadataAttribute("githash","2ebc772b34ec60cde587c6b91c72c726c8e262c3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.16"
