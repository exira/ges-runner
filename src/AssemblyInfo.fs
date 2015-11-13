namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.12")>]
[<assembly: AssemblyFileVersionAttribute("1.0.12")>]
[<assembly: AssemblyMetadataAttribute("githash","977c3d3c19a13d531e99adda2c580b5aa8525903")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.12"
