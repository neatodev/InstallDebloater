namespace InstallDebloater
{
    class Program
    {
        // Input TXT file
        static string[]? MainTXT;

        // Root folder of the game/application
        static string? RootFolder;

        // 0 = relative, 1 = naming_scheme, 2 = folder
        private static bool[] boolList = { false, false, false };

        private static int FileCounter, FolderCounter = 0;

        private static long StartingFileSize = 0;
        private static long FinalFileSize = 0;
        private static long TotalFileSize = 0;

        static void Main(string[] args)
        {
            var output = new Output();
            try
            {
                MainTXT = System.IO.File.ReadAllLines(args[0]);
                DefineRoot(MainTXT[0]);
                InitParams(MainTXT.Skip(1).ToArray());
                if (boolList[0])
                {
                    DeleteRelative(args[0]);
                }
                if (boolList[1])
                {
                    DeleteNamingScheme(args[0]);
                }
                if (boolList[2])
                {
                    DeleteFolder(args[0]);
                }
                FinalFileSize = DefineSize(RootFolder);
                output.message(StartingFileSize, FileCounter, FolderCounter, TotalFileSize, FinalFileSize);
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
        /// Sets the root folder of the application and determines the total file size.
        /// </summary>
        private static void DefineRoot(string root)
        {
            try
            {
                RootFolder = root.Substring(root.LastIndexOf("=") + 1);
                Directory.GetFiles(RootFolder);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(RootFolder + " is not a valid directory or empty.");
                System.Environment.Exit(1);
            }

            StartingFileSize = DefineSize(RootFolder);

            Console.WriteLine(RootFolder + " exists and is not empty.");
        }

        /// <summary>
        /// Calculates the total size of all folders and files. Returns that value.
        /// </summary>
        private static long DefineSize(string folderpath)
        {
            long value = 0;

            DirectoryInfo dirs = new DirectoryInfo(folderpath);

            foreach (var dir in dirs.EnumerateDirectories())
            {
                foreach (var file in dir.EnumerateFiles())
                {
                    value += file.Length;
                }
            }

            foreach (var file in dirs.EnumerateFiles())
            {
                value += file.Length;
            }
            return value;
        }

        /// <summary>
        /// Initializes Parameters to check which extra files to use.
        /// </summary>
        private static void InitParams(string[] parameters)
        {
            for (int i = 0; i <= parameters.Count() - 1; i++)
            {
                if (parameters[i].Substring(parameters[i].LastIndexOf("=") + 1) == "YES" && (parameters[i].Contains("RELATIVE") || parameters[i].Contains("NAMING_SCHEME") || parameters[i].Contains("FOLDER")))
                {
                    boolList[i] = true;
                }
                else if (parameters[i].Substring(parameters[i].LastIndexOf("=") + 1) == "NO" && (parameters[i].Contains("RELATIVE") || parameters[i].Contains("NAMING_SCHEME") || parameters[i].Contains("FOLDER")))
                {
                    boolList[i] = false;
                }
                else
                {
                    Console.WriteLine("Could not initialize parameter: " + parameters[i]);
                    System.Environment.Exit(1);
                }
                Console.WriteLine("Initialized " + parameters[i] + " successfully.");
            }
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
                        System.IO.File.Delete(RootFolder + "\\" + line);
                        Console.WriteLine("Deleted: " + RootFolder + "\\" + line);
                        FileCounter++;
                        TotalFileSize += line.Length;
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
                                System.IO.File.Delete(file);
                                FileCounter++;
                                TotalFileSize += file.Length;
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

                        foreach (var subfolder in subfolders)
                        {

                            var subfiles = Directory.GetFiles(subfolder);
                            foreach (var subfile in subfiles)
                            {
                                System.IO.File.Delete(subfile);
                                Console.WriteLine("Deleting " + subfile + " in folder: " + subfolder);
                                FileCounter++;
                                TotalFileSize += subfile.Length;

                            }

                            System.IO.Directory.Delete(subfolder);
                            FolderCounter++;
                        }
                        var files = Directory.GetFiles(fullpath);
                        foreach (var file in files)
                        {
                            System.IO.File.Delete(file);
                            Console.WriteLine("Deleting " + file + " in folder: " + folder);
                            FileCounter++;
                            TotalFileSize += file.Length;
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