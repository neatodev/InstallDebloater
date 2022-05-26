# Install Debloater for Dying Light

This template is designed to work with Dying Light. Should work with all versions of the game and was tested on the Steam version. 
- Removes a few localizations files. Not all of them can be removed, since it will disable some Online features.
- Removes the "Extras" folder.
- WARNING: Removes Intro Movies. Make sure to add the "-nologos" launch argument otherwise the game won't launch.
- OPTIONAL: Removes the DevTools folder. Will disable the ability to launch "Custom Game". Enable it in DYING_LIGHT_FOLDER.txt.

Expected savings: 19.39% (7.4Gb).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/DYING_LIGHT/DYING_LIGHT.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open DYING_LIGHT.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe DYING_LIGHT\DYING_LIGHT.ini
```
This will run the script.
If you want to keep some languages, take a look at the DYING_LIGHT_NAMING_SCHEME.txt and DYING_LIGHT_FOLDER.txt templates. All languages are isolated, just comment the lines related to the language(s) you want to keep. Make sure to add "-nologos" as a launch argument within Steam or through a shortcut. Lastly, keep in mind that deleting the DevTools folder will break the "Custom Game" launch option. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 