# Install Debloater for Resident Evil Revelations 2

This template is designed to work with RE: Revelations 2.
- Removes all languages except English, some Japanese files are required so only the Japanese voices and subtitles are removed.

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/RE_REV2/RE_REV2.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open RE_REV2.ini with a text editor and add the complete filepath to your game root folder (example: C:\Steam\steamapps\common\Batman Arkham Asylum GOTY).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe RE_REV2/RE_REV2.ini
```
This will run the script.
If you want to keep some languages, take a look at the RE_REV2_NAMING_SCHEME.txt template. All languages are isolated, just comment the lines related to the language(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 