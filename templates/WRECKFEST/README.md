# Install Debloater for Wreckfest

This template is designed to work with Wreckfest. Should work with all versions of the game and was tested on the Steam version. 
- Removes Modding Tools.
- Removes Mod Example.

Expected saving: 3.75% (1,19 GB).

## Installation

[Download](https://github.com/neatodev/InstallDebloater/blob/main/templates/WRECKFEST/WRECKFEST.zip) and put the folder next to InstallDebloater.exe. Run the program either through PowerShell/Commandline or using the provided batch file.

## Usage

First, open WRECKFEST.ini with a text editor and add the complete filepath to your game root folder (example: C:\Program Files (x86)\Steam\steamapps\common\Wreckfest).

For both commandline and batch methods, use the following syntax:

```bash
.\InstallDebloater.exe WRECKFEST\WRECKFEST.ini
```
This will run the script.
If you want to keep some tools, take a look at the WRECKFEST_FOLDER.txt template. Just comment the lines related to the folder(s) you want to keep. 

## Contributing
You are welcome to contribute by making your own templates or improve existing ones. However, please make sure you're not trying to delete critical files. 
