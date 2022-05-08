# InstallDebloater - Saving the Bytes

## What is it?

InstallDebloater is a commandline application that aims to reduce the total file size of applications and games without breaking them. We offer a constantly expanding list of curated, hand-crafted and tested templates that remove the clutter from your apps and games without impacting the core experience. It just saves space on your drives.

## How does it work?

InstallDebloater works with templates. These templates contain one main .ini file, three optional .txt files and a .bat file to run the whole thing. The .ini file specifies which deletion methods are going to be used and the .txt files define which files and folders are going to get deleted.

## What gets deleted?

It depends on the specific game or application. Sometimes we remove unused localization files or multiplayer components that had their servers shut down. Often times developers ship unused assets that bloat the installation size as well, we remove those too. 

Ultimately, what gets deleted and what stays is very specific to that game or application, please check the next section for more information on templates.

[<img src="https://user-images.githubusercontent.com/49599979/167110329-44e38483-d2c0-45f2-b41a-2cc91c6bae0c.png" width="158"/>](https://www.youtube.com/watch?v=PTsLJG5w-T8)

## Templates

In the ['templates'](https://github.com/neatodev/InstallDebloater/tree/main/templates) directory, you will find curated and tested configurations for games and applications that you can just download and run yourself. Every template that we provide has been thoroughly tested by [EVERGREEN](https://github.com/EV3RGR33N) and myself.

Each template has its own unique and detailed README file that explains what it does.

## Examples

In the first example, we manage to reduce the file size of Batman: Arkham Origins by **over 40%**. The template deletes unused localizations and outdated multiplayer components:

![Origins](https://user-images.githubusercontent.com/49599979/163802940-698d9433-11ca-4067-a01e-062542649aaf.png)

In the second example, we reduce the size of Resident Evil: Revelations 2 by **8,96%**. In this case, we remove localization files (sounds, texts, menus...) that we do not use.

![Rev2](https://user-images.githubusercontent.com/49599979/163803078-2543cabe-4527-41ae-8b06-f0ae20f87d8e.png)

## Usage

1. [Download the latest release](https://github.com/neatodev/InstallDebloater/releases). The provided .exe file is needed for the process to work.
2. (Batch Method) If you use a provided .bat file, make sure the folder structure is correct. And the .exe and INIFile are in the correct places relative to each other.
3. (CMD Method) If you run the tool through the commandline, make sure to pass the full path relative to InstallDebloater.exe as an argument.
4. Run it! (Execute .bat file/Run the command in CMD)

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/donate/?hosted_button_id=LG7YTKP4JYN5S)

## Custom Templates

[<img src="https://user-images.githubusercontent.com/49599979/167308289-a7d68726-18cb-444c-a24d-fe786d4faf20.png" width="158"/>](https://www.youtube.com/watch?v=R6KIyPzzvsk)

While we provide curated and tested templates, you can also create your own.

First, you need an .ini file. The name does not matter, but it needs to be universal for all .txt files that depend on it (see structure). The contents of the .ini file need to look like this:

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

naming_scheme.example
naming\scheme\folder.example
```
**Important notice for Linux users:** Yes, the back slashes will work. Only use forward slashes to set your root folder!

In the **_RELATIVE.txt** file, you specify FULL path to files that are _RELATIVE_ to the root folder defined in the .ini file.

In the **_FOLDER.txt** file, you specify the FULL PATH to folders that are _RELATIVE_ to the root folder defined in the .ini file. All files and sub-folders within that folder will get deleted too.

In the **_NAMING_SCHEME.txt** file, you specify certain naming schemes. Every file and folder (starting from root) will get scanned and matching files will get deleted. You can also provide a partial folder structure as long as it contains a target file.


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
