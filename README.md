# OneClipboard
A clipboard syncing app using a file in a OneDrive Folder

## How it works
it uses the [FileSystemWatcher](https://docs.microsoft.com/en-us/dotnet/api/system.io.filesystemwatcher?view=net-6.0) class to listen too file system changes in a text file saved in OneDrive folder

Once a change is detected the text in the text file is added to the clipboard

The RichTextbox is used to edit clipboard data and the text can be added to the text file to be synced with other devices
