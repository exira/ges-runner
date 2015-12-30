open System.Diagnostics
open System.Reflection
open System.IO
open FSharp.Configuration
open Topshelf
open Time

let executablePath = Assembly.GetEntryAssembly().Location |> Path.GetDirectoryName
let configPath = Path.Combine(executablePath, "Runner.yaml")

type RunnerConfig = YamlConfig<"Runner.yaml">
let runnerConfig = RunnerConfig()
runnerConfig.Load configPath

let mutable (proc: Process option) = None

let stop _ =
    let killProcess (p: Process) =
        p.Refresh()

        if p.HasExited then ()
        else
            p.EnableRaisingEvents <- false
            p.Kill()
            p.WaitForExit()
            p.Dispose()

    match proc with
    | None -> true
    | Some p ->
        killProcess p
        proc <- None
        true

let start hostControl =
    let args = sprintf "--config=\"%s\"" runnerConfig.Runner.EventStoreConfigPath
    printfn "Starting %s %s" runnerConfig.Runner.Executable args

    let processInfo = ProcessStartInfo(runnerConfig.Runner.Executable, args, UseShellExecute = false)
    let runningProcess = Process.Start processInfo
    runningProcess.EnableRaisingEvents <- true
    runningProcess.Exited.AddHandler(fun _ _ -> hostControl |> HostControl.restart)

    proc <- Some runningProcess
    true

[<EntryPoint>]
let main argv =
    Service.Default
    |> run_as_local_system
    |> start_auto
    |> enable_shutdown
    |> with_recovery (ServiceRecovery.Default |> restart (min runnerConfig.Runner.RestartIntervalInMinutes))
    |> with_start start
    |> with_stop stop
    |> description runnerConfig.Runner.Description
    |> display_name runnerConfig.Runner.ServiceName
    |> service_name runnerConfig.Runner.ServiceName
    |> depends_on_eventlog
    |> run