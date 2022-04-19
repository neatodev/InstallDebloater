# Install Debloater for Halo MCC

This template is designed to work with BloodRayne: Terminal Cut. Tested on the Steam version. 
Removes all languages except English and deletes the localized FMVs for BloodRayne: Terminal Cut.

## Installation

Download this template and put it next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open BLOODRAYNE_TERMINAL_CUT.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe BLOODRAYNE_TERMINAL_CUT.ini
```
This will run the script.
If you want to keep some languages, take a look at the BLOODRAYNE_TERMINAL_CUT_NAMING_SCHEME.txt and BLOODRAYNE_TERMINAL_CUT_FOLDER.txt templates. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 