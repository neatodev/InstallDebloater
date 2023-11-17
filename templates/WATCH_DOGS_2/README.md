# Install Debloater for Watch_Dogs 2

This template is designed to work with Watch_Dogs 2. Should work with all versions of the game and was tested on the Ubisoft Connect version. 
- Removes unused languages files (aka "Localizations").
- Removes all redistribuables.

Expected saving: 33,21% (~16Gb).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/WATCH_DOGS_2/WATCH_DOGS_2.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open WATCH_DOGS_2.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe WATCH_DOGS_2\WATCH_DOGS_2.ini
```
This will run the script.
If you want to keep some languages, take a look at the WATCH_DOGS_2_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 