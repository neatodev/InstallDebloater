# Install Debloater for Lost Planet 3

This template is designed to work with Lost Planet 3. Should work with all versions of the game and was tested on the Steam version. 
- Removes all languages except English.
- Removes all startup movies that play before reaching the main menu (Publisher logos etc.)
- Optional: Removes all low resolution cutscenes (about 4gb). Make sure that you have the free "Hi Res Movies" DLC installed. Check LOST_PLANET_3_FOLDER.txt to opt-in.

Expected saving: 19.76% (~5.3Gb)

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/LOST_PLANET_3/LOST_PLANET_3.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open LOST_PLANET_3.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe LOST_PLANET_3\LOST_PLANET_3.ini
```
This will run the script.
If you want to keep some languages, take a look at the LOST_PLANET_3_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 