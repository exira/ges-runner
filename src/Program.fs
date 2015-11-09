open FSharp.Configuration
open Topshelf
open Time
open System.Diagnostics

type RunnerConfig = YamlConfig<"Runner.yaml">
let runnerConfig = RunnerConfig()
runnerConfig.Load "Runner.yaml"

let mutable (proc: Process option) = None

let stop _ =
    let killProcess (p: Process) =
        p.Refresh()

        match p.HasExited with
        | true -> true
        | false ->
            p.Kill()
            p.WaitForExit()
            p.Dispose()
            true

    match proc with
    | None -> true
    | Some p -> killProcess p

let start _ =
    let args = sprintf "--config=\"%s\"" runnerConfig.Runner.EventStoreConfigPath
    let processInfo = ProcessStartInfo(runnerConfig.Runner.Executable, args, UseShellExecute = false)
    let runningProcess = Process.Start processInfo;
    runningProcess.Exited.AddHandler(fun sender args -> stop |> ignore)

    proc <- Some runningProcess
    true

[<EntryPoint>]
let main argv =
    Service.Default
    |> run_as_local_system
    |> start_auto
    |> enable_shutdown
    |> with_recovery (ServiceRecovery.Default |> restart (s runnerConfig.Runner.RestartIntervalInSeconds))
    |> with_start start
    |> with_stop stop
    |> description runnerConfig.Runner.Description
    |> display_name runnerConfig.Runner.ServiceName
    |> service_name runnerConfig.Runner.ServiceName
    |> run