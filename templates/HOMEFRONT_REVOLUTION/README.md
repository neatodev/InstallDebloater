# Install Debloater for Homefront: The Revolution

This template is designed to work with Homefront: The Revolution. 
- Removes all languages except English.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/HOMEFRONT_REVOLUTION/HOMEFRONT_REVOLUTION.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open HOMEFRONT_REVOLUTION.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe HOMEFRONT_REVOLUTION\HOMEFRONT_REVOLUTION.ini
```
This will run the script.
If you want to keep some languages, take a look at the HOMEFRONT_REVOLUTION_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 