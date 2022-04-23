# Install Debloater for Middle Earth: Shadow of War

This template is designed to work with Middle Earth: Shadow of War. Should work with all versions of the game and was tested on the Steam version. 
- Removes unused localizations.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/SHADOW_OF_WAR/SHADOW_OF_WAR.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open SHADOW_OF_WAR.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Shadow of War).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe SHADOW_OF_WAR\SHADOW_OF_WAR.ini
```
This will run the script.
If you want to keep some languages, take a look at both .txt files. All languages are isolated, just comment the lines related to the language(s) you want to keep.

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 
