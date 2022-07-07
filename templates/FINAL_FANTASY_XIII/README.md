# Install Debloater for Final Fantasy XIII

This template is designed to work with Final Fantasy XIII. Should work with all versions of the game and was tested on the Steam version. 
 - Removes Japanese pre-rendered cutscenes.
 - OPTIONAL: Removes English pre-rendered cutscenes. Meant for people who play with the Japanese dub. Enable it in FINAL_FANTASY_XIII_NAMING_SCHEME.

Expected saving: 34.52% (20.3Gb).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/FINAL_FANTASY_XIII/FINAL_FANTASY_XIII.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open FINAL_FANTASY_XIII.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe FINAL_FANTASY_XIII\FINAL_FANTASY_XIII.ini
```
This will run the script.
If you want to keep Japanese cutscenes and delete the English ones instead, take a look at the FINAL_FANTASY_XIII_NAMING_SCHEME.txt template. Remove the # character for the Japanese section, and add it to the English one. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 