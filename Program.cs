namespace InstallDebloater
{
    using IniParser;
    using IniParser.Model;
    class Program
    {
        // Root folder of the game/application
        static string? RootFolder;

        private static string[]? Whitelist;

        private static int FileCounter, FolderCounter = 0;

        private static double StartingFileSize = 0;
        private static double FinalFileSize = 0;
        private static double TotalFileSize = 0;

        static void Main(string[] args)
        {
            try
            {
                var ini = new FileIniDataParser();
                IniData data = ini.ReadFile(args[0]);
                RootFolder = data["CORE"]["ROOT"];
                StartingFileSize = DefineSize(RootFolder);
                if (!bool.Parse(data["CORE"]["RELATIVE"]) && !bool.Parse(data["CORE"]["RELATIVE"]) && !bool.Parse(data["CORE"]["RELATIVE"]))
                {
                    Console.WriteLine("No actions specified. Ending the process.");
                    System.Environment.Exit(0);
                }
                if (bool.Parse(data["CORE"]["RELATIVE"]))
                {
                    DeleteRelative(args[0]);
                }
                if (bool.Parse(data["CORE"]["NAMING_SCHEME"]))
                {
                    DeleteNamingScheme(args[0]);
                }
                if (bool.Parse(data["CORE"]["FOLDER"]))
                {
                    DeleteFolder(args[0]);
                }
                FinalFileSize = DefineSize(RootFolder);
                Output.message(StartingFileSize, FileCounter, FolderCounter, TotalFileSize, FinalFileSize);
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of bounds. Please provide a commandline parameter.");
                System.Environment.Exit(1);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not read file. Is the path/filename valid? " + Directory.GetCurrentDirectory() + "\\" + args[0]);
                System.Environment.Exit(1);
            }
        }

        /// <summary>
        /// Calculates the total size of all folders and files. Returns that value.
        /// </summary>
        private static double DefineSize(string folderpath)
        {
            double value = 0;

            var dirs = Directory.GetDirectories(folderpath, "*", System.IO.SearchOption.AllDirectories);

            foreach (var dir in dirs)
            {
                var subfiles = Directory.GetFiles(dir);
                foreach (var subfile in subfiles)
                {
                    value += new FileInfo(subfile).Length;
                }
            }

            var files = Directory.GetFiles(folderpath);
            foreach (var file in files)
            {
                value += new FileInfo(file).Length;
            }
            return value;
        }

        /// <summary>
        /// Deletes files in the *_RELATIVE.txt document. (Files that are relative to ROOT)
        /// </summary>
        private static void DeleteRelative(string arg)
        {

            string relative = arg.Substring(0, arg.LastIndexOf(".")) + "_RELATIVE.txt";

            string[] file = System.IO.File.ReadAllLines(relative);

            foreach (string line in file)
            {
                try
                {
                    if (line.Substring(0, 1).Equals("#") || line.Trim().Equals(""))
                    {
                        continue;
                    }
                    try
                    {
                        TotalFileSize += new FileInfo(RootFolder + "\\" + line).Length;
                        System.IO.File.Delete(RootFolder + "\\" + line);
                        Console.WriteLine("Deleted: " + RootFolder + "\\" + line);
                        FileCounter++;
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Could not find file: " + line);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }
        }

        /// <summary>
        /// Deletes files in the *_NAMING_SCHEME.txt document. (Files with a specific structure)
        /// </summary>
        private static void DeleteNamingScheme(string arg)
        {
            string scheme = arg.Substring(0, arg.LastIndexOf(".")) + "_NAMING_SCHEME.txt";

            string[] schemefile = System.IO.File.ReadAllLines(scheme);

            foreach (string line in schemefile)
            {
                try
                {
                    if (line.Substring(0, 1).Equals("#") || line.Trim().Equals(""))
                    {
                        continue;
                    }

                    var folders = Directory.GetDirectories(RootFolder, "*", System.IO.SearchOption.AllDirectories);

                    foreach (var folder in folders)
                    {
                        var files = Directory.GetFiles(folder);
                        foreach (var file in files)
                        {
                            if (file.Contains(line))
                            {
                                Console.WriteLine("Deleting: " + file);
                                TotalFileSize += new FileInfo(file).Length;
                                System.IO.File.Delete(file);
                                FileCounter++;
                            }
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }
        }

        /// <summary>
        /// Deletes folders in the *_FOLDER.txt document. (Folders and their files that are relative to ROOT)
        /// Also includes subfolders & files.
        /// </summary>
        private static void DeleteFolder(string arg)
        {
            string folderlist = arg.Substring(0, arg.LastIndexOf(".")) + "_FOLDER.txt";

            string[] folderfile = System.IO.File.ReadAllLines(folderlist);

            foreach (string folder in folderfile)
            {
                var fullpath = RootFolder + "\\" + folder;

                try
                {
                    if (folder.Substring(0, 1).Equals("#") || folder.Trim().Equals(""))
                    {
                        continue;
                    }
                    try
                    {
                        System.IO.Directory.Delete(fullpath);
                        Console.WriteLine("Deleting: " + folder);
                        FolderCounter++;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Console.WriteLine("Could not find folder: " + fullpath);
                    }
                    catch (IOException)
                    {
                        var subfolders = Directory.GetDirectories(fullpath, "*", System.IO.SearchOption.AllDirectories);
                        Array.Sort(subfolders);
                        Array.Reverse(subfolders);

                        foreach (var subfolder in subfolders)
                        {

                            var subfiles = Directory.GetFiles(subfolder);
                            foreach (var subfile in subfiles)
                            {
                                TotalFileSize += new FileInfo(subfile).Length;
                                System.IO.File.Delete(subfile);
                                Console.WriteLine("Deleting " + subfile);
                                FileCounter++;
                            }

                            System.IO.Directory.Delete(subfolder);
                            FolderCounter++;
                        }
                        var files = Directory.GetFiles(fullpath);
                        foreach (var file in files)
                        {
                            TotalFileSize += new FileInfo(file).Length;
                            System.IO.File.Delete(file);
                            Console.WriteLine("Deleting " + file);
                            FileCounter++;
                        }
                        Console.WriteLine("Deleting: " + folder);
                        System.IO.Directory.Delete(fullpath);
                        FolderCounter++;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }
        }
    }
}