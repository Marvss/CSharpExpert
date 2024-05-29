namespace CSharpPro;

class Program
{
    static int Main(string[] args)
    {
        // Display a simple message to the user.
        //Console.WriteLine("***** My First C# App *****");
        //Console.WriteLine("Hello World!");

        //Procesing command line arguments
        for(int i = 0; i < args.Length; i++)
        Console.WriteLine("Arg: {0}", args[i]);
        Console.ReadLine();
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}",
        Environment.ProcessorCount);
        Console.WriteLine(".NET Version: {0}",Environment.Version);

        // Print out the drives on this machine,
        // and other interesting details.
        foreach (string drive in Environment.GetLogicalDrives())
        Console.WriteLine("Drive: {0}", drive);
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}",
        Environment.ProcessorCount);
        Console.WriteLine(".NET Version: {0}",
        Environment.Version);
        return -1;
    }
}
