# Install Debloater for Batman Arkham Origins

This template is designed to work with Arkham Origins. Should work with all versions of the game and was tested on the Steam version. 
Removes all languages except English and deletes the now defunct online multiplayer folder.

## Installation

Download this template and put it next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open ARKHAM_ORIGINS.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe ARKHAM_ORIGINS.ini
```
This will run the script.
If you want to keep some languages, take a look at the ARKHAM_ORIGINS_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 