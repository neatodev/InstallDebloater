# Install Debloater for Crysis Remastered

This template is designed to work with Crysis Remastered. Should work with all versions of the game and was tested on the Steam version. 
- Removes all languages except English (aka localizations).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/CRYSIS_REMASTERED/CRYSIS_REMASTERED.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open CRYSIS_REMASTERED.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe CRYSIS_REMASTERED\CRYSIS_REMASTERED.ini
```
This will run the script.
If you want to keep some languages, take a look at the CRYSIS_REMASTERED_RELATIVE.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 