namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ges-runner")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Runner")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Runner is a wrapper that uses Topshelf to run EventStore as a Windows Service")>]
[<assembly: AssemblyVersionAttribute("1.2.25")>]
[<assembly: AssemblyFileVersionAttribute("1.2.25")>]
[<assembly: AssemblyMetadataAttribute("githash","6f09aa153e5012480882767fbade8e03490afe16")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.2.25"
