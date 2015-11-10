namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("0.1.7")>]
[<assembly: AssemblyFileVersionAttribute("0.1.7")>]
[<assembly: AssemblyMetadataAttribute("githash","0fd374d013170fb8f19fe1f019aa949d5ff6ac35")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.7"
