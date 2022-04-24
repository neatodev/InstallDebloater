using System.IO;
namespace InstallDebloater
{
    using System.Text.RegularExpressions;
    using IniParser;
    using IniParser.Model;
    class Program
    {
        // Root folder of the game/application
        private static string? RootFolder;

        private static OperatingSystem os = Environment.OSVersion;
        private static PlatformID pid = os.Platform;

        private static int FileCounter, FolderCounter = 0;
        private static bool IsRelative, IsNamingScheme, IsFolder;
        private static double StartingFileSize = 0;
        private static double FinalFileSize = 0;
        private static double TotalFileSize = 0;

        static void Main(string[] args)
        {
            try
            {
                var ini = new FileIniDataParser();
                IniData data = ini.ReadFile(args[0]);
                Parse(data);
                StartingFileSize = DefineSize(RootFolder);
                if (!IsRelative && !IsNamingScheme && !IsFolder)
                {
                    Console.WriteLine("No actions specified. Ending the process.");
                    System.Environment.Exit(0);
                }
                if (IsRelative)
                {
                    DeleteRelative(args[0]);
                }
                if (IsNamingScheme)
                {
                    DeleteNamingScheme(args[0]);
                }
                if (IsFolder)
                {
                    DeleteFolder(args[0]);
                }
                if (FileCounter == 0 && FolderCounter == 0)
                {
                    Output.failmessage(FileCounter, FolderCounter);
                }
                else
                {
                    FinalFileSize = DefineSize(RootFolder);
                    Output.successmessage(StartingFileSize, FileCounter, FolderCounter, TotalFileSize, FinalFileSize);
                }
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of bounds. Please provide a commandline parameter.");
                Console.ReadLine();
            }
            catch (IniParser.Exceptions.ParsingException)
            {
                Console.WriteLine("Could not parse file. Is the path/format correct? " + System.IO.Path.Combine(Directory.GetCurrentDirectory(), args[0]));
                Console.ReadLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not read file. Is the path/filename valid? " + System.IO.Path.Combine(Directory.GetCurrentDirectory(), args[0]));
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Processes all values from IniData.
        /// </summary>
        private static void Parse(IniData d)
        {
            RootFolder = d["CORE"]["ROOT"];
            IsRelative = bool.Parse(d["CORE"]["RELATIVE"]);
            IsNamingScheme = bool.Parse(d["CORE"]["NAMING_SCHEME"]);
            IsFolder = bool.Parse(d["CORE"]["FOLDER"]);
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
        /// Checks if the OS is Windows. If not, strings get converted. Returns the string.
        /// </summary>
        private static string[] DefinePlatform(string[] list)
        {
            if (pid != PlatformID.Win32NT)
            {
                Regex pattern = new Regex("[\\\\]");

                for (int i = 0; i <= list.Count() - 1; i++)
                {
                    try
                    {
                        list[i] = pattern.Replace(list[i], "/");
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Deletes files in the *_RELATIVE.txt document. (Files that are relative to ROOT)
        /// </summary>
        private static void DeleteRelative(string arg)
        {

            string relative = arg.Substring(0, arg.LastIndexOf(".")) + "_RELATIVE.txt";

            string[] file = DefinePlatform(System.IO.File.ReadAllLines(relative));

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
                        TotalFileSize += new FileInfo(System.IO.Path.Combine(RootFolder, line)).Length;
                        System.IO.File.Delete(System.IO.Path.Combine(RootFolder, line));
                        Console.WriteLine("Deleted: " + System.IO.Path.Combine(RootFolder, line));
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
        /// A partial folder structure that ends with a target file works too.
        /// </summary>
        private static void DeleteNamingScheme(string arg)
        {
            string scheme = arg.Substring(0, arg.LastIndexOf(".")) + "_NAMING_SCHEME.txt";

            string[] schemefile = DefinePlatform(System.IO.File.ReadAllLines(scheme));

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
                        try
                        {
                            var path = System.IO.Path.Combine(RootFolder, folder, line);
                            TotalFileSize += new FileInfo(path).Length;
                            System.IO.File.Delete(path);
                            Console.WriteLine("Deleting: " + path);
                            FileCounter++;
                        }
                        catch (FileNotFoundException)
                        {
                        }
                        catch (DirectoryNotFoundException)
                        {
                        }
                    }

                    var rootfiles = Directory.GetFiles(RootFolder);
                    foreach (var rootfile in rootfiles)
                    {
                        if (rootfile.Contains(line))
                        {
                            Console.WriteLine("Deleting: " + rootfile);
                            TotalFileSize += new FileInfo(rootfile).Length;
                            System.IO.File.Delete(rootfile);
                            FileCounter++;
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

            string[] folderfile = DefinePlatform(System.IO.File.ReadAllLines(folderlist));

            if (pid != PlatformID.Win32NT)
            {
                Regex pattern = new Regex("[\\\\]");

                for (int i = 0; i <= folderfile.Count() - 1; i++)
                {
                    try
                    {
                        folderfile[i] = pattern.Replace(folderfile[i], "/");
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }

            foreach (string folder in folderfile)
            {
                var fullpath = System.IO.Path.Combine(RootFolder, folder);

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
                        Console.WriteLine("Deleting: " + fullpath);
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