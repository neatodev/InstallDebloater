# Install Debloater for PowerSlave Exhumed

This template is designed to work with PowerSlave Exhumed. Should work with all versions of the game and was tested on the GOG version. 
- Removes non-english and intro videos.
- Removes documents for level editor.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/POWERSLAVE_EXHUMED/POWERSLAVE_EXHUMED.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open POWERSLAVE_EXHUMED.ini with a text editor and add the complete filepath to your game root folder (example: C:\Program Files (x86)\Steam\steamapps\common\PowerSlave Exhumed).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe POWERSLAVE_EXHUMED\POWERSLAVE_EXHUMED.ini
```
This will run the script.
If you are a level editor user, then go to the POWERSLAVE_EXHUMED.ini and change FOLDER=true to FOLDER=false to prevent deleting documentation on the use of the level editor.

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files.
