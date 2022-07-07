# Install Debloater for BeamNG.drive

This template is designed to work with BeamNG.drive. Should work with all versions of the game and was tested on the Steam version. 
- Removes Linux binaries.
- Removes Visual C Redistributables.

Expected saving: 1.16% (382,5 MB).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/BEAMNG.DRIVE/BEAMNG.DRIVE.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open BEAMNG.DRIVE.ini with a text editor and add the complete filepath to your game root folder (example: C:\Program Files (x86)\Steam\steamapps\common\BeamNG.drive).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe BEAMNG.DRIVE\BEAMNG.DRIVE.ini
```
This will run the script.
If you want to keep some tools, take a look at the WRECKFEST_FOLDER.txt template. Just comment the lines related to the folder(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 
