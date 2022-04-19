# Install Debloater for Batman Arkham City GOTY

This template is designed to work with Arkham City GOTY. Should work with all versions of the game and was tested on the Steam version. 
- Removes all languages except English.
- Deletes the Setup folder. Make sure to run the game at least one before using this template.
- Removes all startup movies that play before reaching the main menu (Publisher logos etc.).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/ARKHAM_CITY/ARKHAM_CITY.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open ARKHAM_CITY.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe ARKHAM_CITY\ARKHAM_CITY.ini
```
This will run the script.
If you want to keep some languages, take a look at the ARKHAM_CITY_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 