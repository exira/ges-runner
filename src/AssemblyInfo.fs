namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("0.1.9")>]
[<assembly: AssemblyFileVersionAttribute("0.1.9")>]
[<assembly: AssemblyMetadataAttribute("githash","24dbc840f35901be520a180c6a2f6c2614d7943c")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.9"
