# ges-runner

Wrapper that uses [Topshelf](http://topshelf-project.com/) to run EventStore (https://geteventstore.com/) as a Windows Service.

## Usage

To install do the following:

  * Download `Event Store` from https://geteventstore.com

  * Download a release from the [Releases page](https://github.com/exira/ges-runner/releases) and unzip somewhere, for example `C:\ges-runner\`

  * Update `Runner.yaml` file with location to `EventStore.ClusterNode.exe` to run and the `.esconfig` you wish to use, according to [YAML documentation](http://docs.geteventstore.com/server/3.3.0/command-line-arguments/)

  * Run the `Install.ps1` script with the same servicename you configured in `Runner.yaml`, for example: `powershell ./Install.ps1 -servicename ges`

  * Instead you can also simply run one of the following:
    * `ges-runner.exe install`
    * `ges-runner.exe start`
    * `ges-runner.exe stop`
    * `ges-runner.exe uninstall`

  * Enjoy Event Store

## Example Output

```
λ ges-runner.exe install
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
```

```
λ ges-runner.exe start
Configuration Result:
[Success] Name ges
[Success] Description Run Event Store
[Success] ServiceName ges
Topshelf v3.2.150.0, .NET Framework v4.0.30319.42000
The ges service was started.
```

```
λ ges-runner.exe stop
Configuration Result:
[Success] Name ges
[Success] Description Run Event Store
[Success] ServiceName ges
Topshelf v3.2.150.0, .NET Framework v4.0.30319.42000
The ges service was stopped.
```

```
λ ges-runner.exe uninstall
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
```

## Cloning

`git clone git@github.com:exira/ges-runner.git -c core.autocrlf=input`

## License

ges-runner is licensed under [MIT](http://choosealicense.com/licenses/mit/ "Read more about the MIT License"). Refer to [LICENSE.txt](https://github.com/exira/ges-runner/blob/master/LICENSE.txt) for more information

Code copied from this gist: https://gist.github.com/trbngr/5083266

Forked from https://github.com/mastoj/EventStoreWinServiceWrapper
