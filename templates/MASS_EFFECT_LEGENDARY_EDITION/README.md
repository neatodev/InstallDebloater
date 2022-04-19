# Install Debloater for Mass Effect: Legendary Edition

This template is designed to work with Mass Effect: Legendary Edition. Should work with all versions of the game and was tested on the Origin version. 
- Removes all languages except English.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/MASS_EFFECT_LEGENDARY_EDITION/MASS_EFFECT_LEGENDARY_EDITION.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open ME_LE.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Mass Effect Legendary Edition).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe MASS_EFFECT_LEGENDARY_EDITION\ME_LE.ini
```
This will run the script.
If you want to keep some languages, take a look at the ME_LE_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 