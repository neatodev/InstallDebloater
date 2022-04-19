# Install Debloater for DOOM 2016

This template is designed to work with DOOM 2016. Should work with all versions of the game and was tested on the Steam version. 
- Removes all languages except English
- Deletes the multiplayer and Snapmap modes.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/DOOM_2016/DOOM_2016.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open DOOM_2016.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe DOOM_2016\DOOM_2016.ini
```
This will run the script.
If you want to keep some languages or game modes take a look at the DOOM_2016_FOLDER.txt and DOOM_2016_RELATIVE.txt templates. All languages & modes are isolated, just comment the lines related to the one(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 