# Install Debloater for Alien Isolation

This template is designed to work with Alien Isolation. Should work with all versions of the game and was tested on the Steam version. 
- Removes all languages except English,
- Removes all startup movies that play before reaching the main menu (Publisher logos etc.),
- Removes the "Extras" folder (Banners, game cover art),

Estimated savings: 6.88% (2.1Gb)

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/ALIEN_ISOLATION/ALIEN_ISOLATION.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open ALIEN_ISOLATION.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe ALIEN_ISOLATION\ALIEN_ISOLATION.ini
```
This will run the script.
If you want to keep some languages, take a look at the ALIEN_ISOLATION_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 