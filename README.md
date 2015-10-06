# ges-runner

Wrapper that uses [Topshelf](http://topshelf-project.com/) to run EventStore (https://geteventstore.com/) as a Windows Service.

## Usage

To install do the following:

  * Download Event Store from http://geteventstore.com
  
  * Download a release from the [Releases page](https://github.com/exira/ges-runner/releases) and unzip somewhere, for example ```C:\ges-runner\```
  
  * Update ```ges-runner.exe.config``` file with location to ```EventStore.ClusterNode.exe``` to run and the ```.esconfig``` you wish to use, according to [YAML documentation](http://docs.geteventstore.com/server/3.2.0/command-line-arguments/)
  
  * Run the ```Install.ps1``` script with the same servicename you configured in ```ges-runner.exe.config```, for example: ```powershell ./Install.ps1 -servicename ges```

  * Enjoy Event Store

## Cloning

```git clone git@github.com:exira/ges-runner.git -c core.autocrlf=input```

## License

ges-runner is licensed under [MIT](http://choosealicense.com/licenses/mit/ "Read more about the MIT License"). Refer to [LICENSE](https://github.com/exira/ges-runner/blob/master/LICENSE) for more information

Code copied from this gist: https://gist.github.com/trbngr/5083266

Forked from https://github.com/mastoj/EventStoreWinServiceWrapper
