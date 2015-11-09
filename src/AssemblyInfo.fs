namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("0.1.0")>]
[<assembly: AssemblyFileVersionAttribute("0.1.0")>]
[<assembly: AssemblyMetadataAttribute("githash","2f8d02e320a52cab40b001169b0d44d6b4bf4f76")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.0"
