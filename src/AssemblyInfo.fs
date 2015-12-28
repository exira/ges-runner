namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.1.24")>]
[<assembly: AssemblyFileVersionAttribute("1.1.24")>]
[<assembly: AssemblyMetadataAttribute("githash","8918b7b086b8e174254958bb6542e02a16ca6a0c")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.24"
