namespace CSharpPro;

class Program
{
    static int Main(string[] args)
    {
        // Display a simple message to the user.
        Console.WriteLine("***** My First C# App *****");
        Console.WriteLine("Hello World!");

        //Procesing command line arguments
        for(int i = 0; i < args.Length; i++)
        Console.WriteLine("Arg: {0}", args[i]);
        Console.ReadLine();
        return -1;

    }
}
