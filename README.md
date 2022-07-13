# ![OneClipboard icon](https://github.com/playtunes100/OneClipboard/blob/6f52a350ad0ef2111ae7ad11b1e7ae9384856c56/OneClipboard/Clipboard-check-02.ico) OneClipboard
A clipboard syncing app using a file in a OneDrive Folder

## How it works
it uses the [FileSystemWatcher](https://docs.microsoft.com/en-us/dotnet/api/system.io.filesystemwatcher?view=net-6.0) class to listen to file system changes in a text file saved in OneDrive folder

Once a change is detected the text in the text file is added to the clipboard

The RichTextbox is used to edit clipboard data and update the clipboard

Changes to the clipboard are detected by a [SharpClipboard](https://github.com/Willy-Kimura/SharpClipboard) event handler and added to the file in Onedrive

## How to use
Download and extract the `OneClipboard v1.0.0.zip` file

run the `setup.exe` file

Overview screenshot

![Main menu](https://github.com/playtunes100/OneClipboard/blob/6f52a350ad0ef2111ae7ad11b1e7ae9384856c56/images/main.png)

First click the ![Select file button](https://github.com/playtunes100/OneClipboard/blob/6f52a350ad0ef2111ae7ad11b1e7ae9384856c56/images/selectfile.png) to choose the clipboard.txt file in your OneDrive folder if it has already been created.

If not create a new file and select it, but ensure that both devices use the same file.

Then click the ![Start watch button](https://github.com/playtunes100/OneClipboard/blob/6f52a350ad0ef2111ae7ad11b1e7ae9384856c56/images/startwatch.png) to start watching the file for changes.

The file's path will be saved in the app settings and will be available next time the app is launched.

The Textbox area is for editing clipboard data, to add the text to the clipboard click ![Add to clipboard button](https://github.com/playtunes100/OneClipboard/blob/6f52a350ad0ef2111ae7ad11b1e7ae9384856c56/images/addtoclipboard.png)

If you want the app to launch on startup check the ![Startup check](https://github.com/playtunes100/OneClipboard/blob/6f52a350ad0ef2111ae7ad11b1e7ae9384856c56/images/startup.png) checkbox.

This also allows the app to launch in the background.

To see the window click the app icon in the system tray on the bottom right of the screen ![icon in system tray](https://github.com/playtunes100/OneClipboard/blob/5b8b6b6efd208f1478eeb20354df4179e474c933/images/system%20tray.png)








