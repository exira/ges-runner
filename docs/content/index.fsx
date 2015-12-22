(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
ges-runner [![NuGet Status](http://img.shields.io/nuget/v/Exira.EventStore.Runner.svg?style=flat)](https://www.nuget.org/packages/Exira.EventStore.Runner/)
======================

Wrapper that uses [Topshelf](http://topshelf-project.com/) to run [EventStore]([https://geteventstore.com/](https://geteventstore.com/)) as a Windows Service.

### Usage

To install do the following:

  * Download `Event Store` from [https://geteventstore.com/](https://geteventstore.com/)

  * Download a release from the [Releases page](https://github.com/exira/ges-runner/releases) and unzip somewhere, for example `C:\ges-runner\`

  * Update `Runner.yaml` file with location to `EventStore.ClusterNode.exe` to run and the `.esconfig` you wish to use, according to [YAML documentation](http://docs.geteventstore.com/server/3.3.0/command-line-arguments/)

  * Run the `Install.ps1` script with the same servicename you configured in `Runner.yaml`, for example: `powershell ./Install.ps1 -servicename ges`

  * Instead you can also simply run one of the following:
    * `ges-runner.exe install`
    * `ges-runner.exe start`
    * `ges-runner.exe stop`
    * `ges-runner.exe uninstall`

  * Enjoy Event Store

### Example Output

<pre><code>λ ges-runner.exe install
Configuration Result:
[Success] Name ges
[Success] Description Run Event Store
[Success] ServiceName ges
Topshelf v3.2.150.0, .NET Framework v4.0.30319.42000
Running a transacted installation.
Beginning the Install phase of the installation.
Installing ges service
Installing service ges...
Service ges has been successfully installed.
The Install phase completed successfully, and the Commit phase is beginning.
The Commit phase completed successfully.
The transacted install has completed.
</code></pre>

<pre><code>λ ges-runner.exe start
Configuration Result:
[Success] Name ges
[Success] Description Run Event Store
[Success] ServiceName ges
Topshelf v3.2.150.0, .NET Framework v4.0.30319.42000
The ges service was started.
</code></pre>

<pre><code>λ ges-runner.exe stop
Configuration Result:
[Success] Name ges
[Success] Description Run Event Store
[Success] ServiceName ges
Topshelf v3.2.150.0, .NET Framework v4.0.30319.42000
The ges service was stopped.
</code></pre>

<pre><code>λ ges-runner.exe uninstall
Configuration Result:
[Success] Name ges
[Success] Description Run Event Store
[Success] ServiceName ges
Topshelf v3.2.150.0, .NET Framework v4.0.30319.42000

The uninstall is beginning.
Uninstalling ges service
Removing EventLog source ges.
Service ges is being removed from the system...
Service ges was successfully removed from the system.
The uninstall has completed.
</code></pre>

### Cloning

`git clone git@github.com:exira/ges-runner.git -c core.autocrlf=input`

### Contributing and copyright

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork
the project and submit pull requests. You might also want to read the
[library design notes][readme] to understand how it works.

For more information see the [License file][license] in the GitHub repository.

  [content]: https://github.com/exira/ges-runner/tree/master/docs/content
  [gh]: https://github.com/exira/ges-runner
  [issues]: https://github.com/exira/ges-runner/issues
  [readme]: https://github.com/exira/ges-runner/blob/master/README.md
  [license]: https://github.com/exira/ges-runner/blob/master/LICENSE.txt
*)
