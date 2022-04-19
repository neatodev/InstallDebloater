# Install Debloater for Halo MCC

This template is designed to work with Halo MCC. Tested on the Steam version. 
- Removes all languages except English
- Deletes startup movies that play before reaching the main menu (Publisher logos etc)
- Deletes the localized intro movies for Halo 3: ODST.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/HALO_MCC/HALO_MCC.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open HALO_MCC.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe HALO_MCC/HALO_MCC.ini
```
This will run the script.
If you want to keep some languages, take a look at the HALO_MCC_NAMING_SCHEME.txt and HALO_MCC_FOLDER.txt templates. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 