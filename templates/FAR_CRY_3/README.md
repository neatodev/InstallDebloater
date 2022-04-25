# Install Debloater for Far Cry 3

This template is designed to work with Far Cry 3. Should work with all versions of the game and was tested on the Steam version. 
- Removes unused languages files (aka "Localizations").
- Removes all redistribuables.
- Removes the files from the Deluxe Edition (Survival Guide & Soundtrack)

Expected saving: 30.14% (3.6Gb).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/FAR_CRY_3/FAR_CRY_3.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open FAR_CRY_3.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe FAR_CRY_3\FAR_CRY_3.ini
```
This will run the script.
If you want to keep some languages, take a look at the FAR_CRY_3_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 