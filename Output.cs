namespace InstallDebloater
{
    internal class Output
    {

        internal void message(long start, long totalfiles, long totalfolders, long totalfilesize, long final)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Deletion Process completed successfully. ");
            Console.WriteLine("Starting Size: " + (start / 1024 / 1024 / 1024) + "GB. Final Size: " + (final / 1024 / 1024 / 1024) + "GB.");
            Console.WriteLine("Deleted a total of " + totalfiles + " files and " + totalfolders + " folders.");
            Console.WriteLine("The total deleted filesize amounts to: " + (totalfilesize / 1024 / 1024 / 1024) + "GB.");
            Console.WriteLine("The folder size has been reduced by: " + ((100 - (start / final)) * 100) + "%");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
        }
    }
}