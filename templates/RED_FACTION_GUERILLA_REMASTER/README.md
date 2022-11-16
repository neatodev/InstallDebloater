# Install Debloater for Red Faction Guerrilla Re-MARS-tered.

This template is designed to work with Red Faction Guerrilla Re-MARS-tered. Should work with all versions of the game and was tested on the Steam version. 
- Removes all languages except English.
- Removes all startup movies that play before reaching the main menu (Publisher logos etc.).

Expected saving: 12.51% (~3.9Gb)

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/RED_FACTION_GUERILLA_REMASTER/RED_FACTION_GUERILLA_REMASTER.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open RED_FACTION_GUERILLA_REMASTER.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe RED_FACTION_GUERILLA_REMASTER\RED_FACTION_GUERILLA_REMASTER.ini
```
This will run the script.
If you want to keep some languages, take a look at the RED_FACTION_GUERILLA_REMASTER_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 