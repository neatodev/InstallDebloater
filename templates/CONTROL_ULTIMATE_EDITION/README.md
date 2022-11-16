# Install Debloater for Control Ultimate Edition

This template is designed to work with Control Ultimate Edition. Tested on the Steam version, should work with EGS's Ultimate version as well. 
- Removes all languages except English.

Expected saving: 2.08% (1056.422Mb)

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/CONTROL_ULTIMATE_EDITION/CONTROL_ULTIMATE_EDITION.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open CONTROL_ULTIMATE_EDITION.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe CONTROL_ULTIMATE_EDITION\CONTROL_ULTIMATE_EDITION.ini
```
This will run the script.
If you want to keep some languages, take a look at the CONTROL_ULTIMATE_EDITION_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 