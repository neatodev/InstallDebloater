namespace InstallDebloater
{
    class Program
    {
        static string[]? MainTXT;
        static string? RootFolder;

        // 0 = relative, 1 = naming_scheme, 2 = folder
        private static bool[] boolList = { false, false, false };

        static void Main(string[] args)
        {
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
            Console.WriteLine(RootFolder + " exists and is not empty.");
        }

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
                            }
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }
        }

        private static void DeleteFolder(string arg)
        {
            string folderlist = arg.Substring(0, arg.LastIndexOf(".")) + "_FOLDER.txt";

            string[] folderfile = System.IO.File.ReadAllLines(folderlist);

            foreach (string folder in folderfile)
            {
                try
                {
                    if (folder.Substring(0, 1).Equals("#") || folder.Trim().Equals(""))
                    {
                        continue;
                    }
                    try
                    {
                        System.IO.Directory.Delete(RootFolder + "\\" + folder);
                        Console.WriteLine("Deleting: " + folder);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Console.WriteLine("Could not find folder: " + RootFolder + "\\" + folder);
                    }
                    catch (IOException)
                    {
                        var subfolders = Directory.GetDirectories(folder, "*", System.IO.SearchOption.AllDirectories);

                        foreach (var subfolder in subfolders)
                        {
                            try
                            {
                                var subfiles = Directory.GetFiles(subfolder);
                                foreach (var subfile in subfiles)
                                {
                                    System.IO.File.Delete(subfile);
                                    Console.WriteLine("Deleting " + subfile + " in folder: " + subfolder);
                                }
                            }
                            catch (FileNotFoundException)
                            {
                            }
                            System.IO.Directory.Delete(subfolder);
                        }
                        var files = Directory.GetFiles(RootFolder + "\\" + folder);
                        foreach (var file in files)
                        {
                            System.IO.File.Delete(file);
                            Console.WriteLine("Deleting " + file + " in folder: " + folder);
                        }
                        Console.WriteLine("Deleting: " + folder);
                        System.IO.Directory.Delete(RootFolder + "\\" + folder);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }
        }
    }
}