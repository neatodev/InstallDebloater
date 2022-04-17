# InstallDebloater - Saving the Bytes

## What is it?

InstallDebloater is a commandline application that aims to reduce the total file size of applications and games without breaking them. We offer a constantly expanding list of curated, hand-crafted and tested templates that remove the clutter from your apps and games without impacting the core experience. It just saves space on your drives.

## Templates

In the ['templates'](https://github.com/neatodev/InstallDebloater/tree/main/templates) directory, you will find curated and tested configurations for games and applications that you can just download and run yourself. Every template that we provide has been thoroughly tested by [EVERGREEN](https://github.com/EV3RGR33N) and myself.

## Usage

1. [Download the latest release](https://github.com/neatodev/InstallDebloater/releases). The provided .exe file is needed for the process to work.
2. (Batch Method) If you use a provided .bat file, make sure the folder structure is correct. And the .exe and INIFile are in the correct places relative to each other.
3. (CMD Method) If you run the tool through the commandline, make sure to pass the full path relative to InstallDebloater.exe as an argument.
4. Run it! (Execute .bat file/Run the command in CMD)


[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/donate/?hosted_button_id=LG7YTKP4JYN5S)

## Custom Templates

While we provide curated and tested templates, you can also create your own.

First, you need an .ini file. The name does not matter, but it needs to be universal for all .txt files (see structure). The contents of the .ini file need to look like this:

```
; This is an example for a comment. You can place comments anywhere.

[CORE]
ROOT=GAMEFOLDER
RELATIVE=true/false
NAMING_SCHEME=true/false
FOLDER=true/false
```

Once you've prepared your .ini file, you need sub-files that actually do the work. These sub-files all have the .txt format and are only needed if you set their value in .ini to true. They all follow identical formatting rules.

```
# This is an example for a comment. You can place comments anywhere.

dat\relative\example\file.txt

dat\folder\example\dir

naming_scheme_example
```
In the **_RELATIVE.txt** file, you specify FULL path to files that are _RELATIVE_ to the root folder defined in the .ini file.

In the **_FOLDER.txt** file, you specify the FULL PATH to folders that are _RELATIVE_ to the root folder defined in the .ini file. All files and sub-folders within that folder will get deleted too.

In the **_NAMING_SCHEME.txt**, you specify certain naming schemes. Every file and folder (starting from root) will get scanned and matches will be deleted.


The structure for all files is as follows:

```
Application.ini--|
                 |--Application_FOLDER.txt*
                 |--Application_NAMING_SCHEME.txt*
                 |--Application_RELATIVE.txt*

*Only required if the value is 'true' in the .ini file.
```


## Contributing

We are happy to receive template contributions for apps and games that we do not currently  support ourselves. If you would like to contribute and submit a Pull Request, please make sure that you follow the naming & formatting structure in the ['templates'](https://github.com/neatodev/InstallDebloater/tree/main/templates) folder. Please also make sure to only submit one application/game as a commit at a time.

### License
[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://github.com/neatodev/InstallDebloater/blob/main/LICENSE)
