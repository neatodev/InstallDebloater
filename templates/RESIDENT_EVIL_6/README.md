# Install Debloater for Resident Evil 6

This template is designed to work with Resident Evil 6.
- Removes unused languages files (aka "Localizations").
- Removes redistruables. Make sure to run the game at least once before running this template.
- Removes the files from the Digital Soundtrack DLC.
- Removes the files from the Digital Artbook DLC.
- Removes the files from the Wallpapers Set DLC 
## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/RESIDENT_EVIL_6/RESIDENT_EVIL_6.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open RESIDENT_EVIL_6.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe RESIDENT_EVIL_6\RESIDENT_EVIL_6.ini
```
This will run the script.
If you want to keep some languages, take a look at both RESIDENT_EVIL_6_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 