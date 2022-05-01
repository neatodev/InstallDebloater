# Install Debloater for BioShock Remastered

This template is designed to work with BioShock Remastered. Should work with all versions of the game and was tested on the Steam version. 
- Removes unused languages files (aka "Localizations").
- Removes the Startup Movies that play before reaching the main menu (Publisher logos etc.).

Expected savings: 15.43% (3.2Gb)

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/BIOSHOCK_REMASTERED/BIOSHOCK_REMASTERED.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open BIOSHOCK_REMASTERED.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe BIOSHOCK_REMASTERED\BIOSHOCK_REMASTERED.ini
```
This will run the script.
If you want to keep some languages, take a look at the BIOSHOCK_REMASTERED_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 