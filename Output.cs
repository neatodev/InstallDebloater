namespace InstallDebloater
{
    internal class Output
    {

        internal static void message(double start, int totalfiles, int totalfolders, double totalfilesize, double final)
        {
            Console.WriteLine();
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Deletion Process completed successfully. ");
            Console.WriteLine("Starting Size: " + Math.Round(((start / 1024) / 1024), 3) + "MB. Final Size: " + Math.Round(((final / 1024) / 1024), 3) + "MB.");
            Console.WriteLine("Deleted a total of " + totalfiles + " files and " + totalfolders + " folders.");
            Console.WriteLine("The total deleted file size amounts to: " + Math.Round(((totalfilesize / 1024) / 1024), 3) + "MB.");
            Console.WriteLine("The folder size has been reduced by: " + Math.Round(((final / start) * 100), 2) + "%");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine();
        }
    }
}