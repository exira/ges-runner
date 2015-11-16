namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.0.17")>]
[<assembly: AssemblyFileVersionAttribute("1.0.17")>]
[<assembly: AssemblyMetadataAttribute("githash","04161b6fc2d69f573e6f1ff07ad29e1ea58e96b7")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.17"
