<h1 align="center">Reconfigurationed </h1>


<p align="center"><img src="https://img.shields.io/badge/Version-v2.0-informational?style=flat&logo=csharp"> <img src="https://img.shields.io/badge/Compatible%20With-Macbook%2C%20Linux%20%26%20Windows-important"> <img src="https://img.shields.io/badge/License-MIT-inactive"></p>

<p align="center">
  A custom terminal that runs In C# and was made in VSC on a macOS. <br>
  The project is currently working in progress. so please be pacient for the next update in Reconfigurationed..
  


  
  
  
  
  
</p>
<br><br><br>

<h2>Installation Guide</h2>
Please read this guide if you want to install Reconfigurationed. <br>

<h3>MacOS/Linux (Terminal)</h3>

Make sure you run: 

```bash
git clone https://github.com/NotHansCYDIa/Reconfigurationed.git
```

After you run the code go to `theDirectoryYouCloned/app/Program.cs` and <b>manually run the project by pressing `F5` if you're in windows, press `fn + F5` if you're in macOS.</b> Then go to `bin/Debug/net7.0/app` if the file isnt an executable file then open terminal and run 
```bash
cd theDirectoryYouCloned/app/bin/Debug/net7.0
chmod +x app
```
and the file should be an executable file. <br><br><br><br>



<h3>How to fix “app” cannot be opened because it is from an unidentified developer. (macOS only)</h3>

When you're sent an alert after double-clicking the app executable file and the alert says `“app” cannot be opened because it is from an unidentified developer.`, click on System Preferences on your mac then go to `Privacy & Security` then scroll down until you see `Allow applications downloaded from` and toggle `App Store and identified developers`, then double-click the app executable file and go you should see `"app" was blocked from use because it is not from an identified developer` under the `Allow applications downloaded from` section from the `Privacy & Security` tab, now click `Open Anyway` on the message to open the app executable file. if you got a message saying `macOS cannot verify the developer of “app”. Are you sure you want to open it?` when you click `Open Anyway` press `Open` and it should run the app executable file. <br><br><br>




<h3>Windows (Command Prompt)</h3>

<h4>Method 1</h4>

To use Recheckered in Windows, try to use a virtual machine `e.g. VirtualBox VM`, then run the latest macOS Ventura or Monterey and follow the guide for <b>MacOS/Linux (Terminal)</b>

<h4> Method 2</h4>

Go to `theDirectoryYouCloned/app` and click on `Program.cs` and <b>press `F5` and click on `.NET Framework 4.x (Windows only)`</b>.

<h4>Other Methods</h4>

```diff
- There are currently no other methods on how to install Recheckered.
! Recheckered might be not compatible on Windows in the future.
```




<br><br><br>

<h2>Features</h2>

- [x] import command
- [x] clear command
- [x] reset command
- [x] echo command
- [ ] access command
- [ ] system command
- [ ] -info extension
- [ ] -local extension
- [ ] -properties extension
- [x] -config extension
