# Install Debloater for Lost Planet Colonies Edition

- Removes unused languages files (aka "Localizations").
- Removes redistruables. Make sure to run the game at least once before running this template.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/LOST_PLANET_COLONIES_EDITION/LOST_PLANET_COLONIES_EDITION.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open LOST_PLANET_COLONIES_EDITION.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe LOST_PLANET_COLONIES_EDITION\LOST_PLANET_COLONIES_EDITION.ini
```
This will run the script.
If you want to keep some languages, take a look at both LOST_PLANET_COLONIES_EDITION_6_NAMING_SCHEME.txt and LOST_PLANET_COLONIES_EDITION_FOLDER.txt templates. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 