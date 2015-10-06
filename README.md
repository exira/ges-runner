# ges-runner

Service wrapper that uses [Topshelf](http://topshelf-project.com/) to run EventStore (https://geteventstore.com/)

## Usage

To install do the following:

 1. Download Event Store from http://geteventstore.com.
 2. Download a release from [releases](https://github.com/exira/ges-runner/releases) and unzip somewhere where you know where it is, for example ```C:\ges-runner\```.
 3. Update ```ges-runner.exe.config``` file with location to ```EventStore.ClusterNode.exe``` to run and the ```.esconfig``` you wish to use.
 4. Run the ```Install.ps1``` script from the release. (```powershell ./Install.ps1 -servicename ges```)
 5. Enjoy Event Store

 ## License

ges-runner is licensed under [MIT](http://choosealicense.com/licenses/mit/ "Read more about the MIT License"). Refer to [LICENSE](https://github.com/exira/ges-runner/blob/master/LICENSE) for more information

Code copied from this gist: https://gist.github.com/trbngr/5083266
Forked from https://github.com/mastoj/EventStoreWinServiceWrapper
