# Universal installer for DELTARUNE and UNDERTALE by USP

Bye!
We finally have a universal installer! With this you can patch * UNDERTALE * and * DELTARUNE * (Chapter 1 and 2), both on ** Windows **, ** macOS ** and ** Linux **! The installer will also allow you to update the patch in case we release updates. In short, convenient!

## Compatibility

The installer is compatible with the following versions of the games:
- ** DELTARUNE (Chaper 1 & 2 DEMO) **, version ** 1.07 **
- ** UNDERTALE **, version ** 1.08 **
And with any version of Windows, macOS or Linux distribution capable of running **. NET Runtime 5.0 ** (more info in the prerequisites).

## Prerequisites

- First, find the folder where you have installed * UNDERTALE * or * DELTARUNE *; generally, for example on Windows, if you have installed the game via Steam, this will be:
``
C: \ Program Files (x86) \ Steam \ steamapps \ common \ Undertale
// or
C: \ Program Files (x86) \ Steam \ steamapps \ common \ DELTARUNEdemo
``
- Check if your system is 32Bit or 64Bit, you can do it by going to System Information from the Windows search bar at the bottom left.
- ** For Windows and Linux only **, install the .NET 5.0 runtime from here: https://dotnet.microsoft.com/download/dotnet/5.0/runtime,
- ** Windows **: Select * Download x64 * or * Download x86 * under * Run desktop apps *, depending on whether you have a 64 or 32-bit system respectively, and install the runtime following the instructions,
- ** Linux **: Follow the instructions for your distribution here: https://docs.microsoft.com/it-it/dotnet/core/install/linux, in particular you will need to install the ** dotnet-runtime- package 5.0 **
-
## Installation on Windows
- Download the .zip file with the installer from the site https://undertaleita.net/
- Unzip the contents of the file into a folder
- Open * Italian Patcher by USP *
- Wait for the installer to download the updates, then click ** Install **.
- Click on ** Browse ** and select, from the folder where you installed the game, the file ** data.win **, or ** DELTARUNE.exe ** or ** UNDERTALE.exe **.
- Click ** Apply Patch **, and wait
- As soon as it's all over, your game will be translated! You can now start it and play

** NOTE **: If when you try to start the exe Windows blocks you with a Windows SmartScreen popup, click on * More Info *, and then on * Run anyway *.

## Installation on macOS
- Download the .tar file with the installer from the site https://undertaleita.net/
- Unzip the contents of the file
- Move the * Italian Patch by USP * file to the * Applications * folder (** IMPORTANT **)
- Open the * Finder *, navigate to the * Applications * folder, right click on * Spaghetti Installer * and click on ** Open **.
- Accept any warnings that will appear on the screen.
- Wait for the installer to download the updates, then click ** Install **.
- Click on ** Browse ** and select, from the folder where you installed the game, the file ** game.ios **, or ** DELTARUNE.app ** or ** UNDERTALE.app **.
- Click ** Apply Patch **, and wait
- As soon as it's all over, your game will be translated! You can now start it and play

## Installation on Linux
** NOTE **: Instructions for Linux will be provided to be executed via the terminal.
- Download the .tar file with the installer from the site https://undertaleita.net/
- Unzip the contents of the file into a folder
- ** MAKE SURE YOU HAVE INSTALLED THE .NET RUNTIME **, read the prerequisites in case.
- Open a terminal window, and navigate via `cd` to the directory where you unzipped, for example if I unzipped the game in` ~ / SpaghettiInstaller` I'll do:
``
$ cd ~ / SpaghettiInstaller
``
- Now execute the following commands:
``
$ chmod a + x ItalianPatcherLinux.sh
$ ./ItalianPatcherLinux.sh
``
- Wait for the installer to download the updates, then click ** Install **.
- Click on ** Browse ** and select the ** game.unx ** file from the folder where you installed the game
- Click ** Apply Patch **, and wait
- As soon as it's all over, your game will be translated! You can now start it and play

## Additional Notes
The installer was possible thanks to our [@Nik] (https://github.com/nkrapivin). Plus, special thanks to [@krzys_h] (https://github.com/krzys-h) for developing * UndertaleModTool *, which was essential for development.

If you have any problems, write us on Facebook or send us an email at *undertalespaghettiproject@gmail.com*. Thanks for your support and patience! We hope you enjoy DELTARUNE and UNDERTALE in Italian!

Soon!

* Renard *

## Building notes (in English)

for Windows and Linux there's a VS publishing profile called `ReleaseProfile`, use that.

for macOS, open `View` ->` Terminal`, type `. / macOSBuild.ps1`, hit Enter, wait for the` .app` "folder" in `SpaghettiCh2 / bin / Release / net5.0 / publish / USPMac `. Archive as .tar under Windows.