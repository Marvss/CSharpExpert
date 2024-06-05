namespace CSharpPro;

class Program
{
    static int Main(string[] args)
    {
        // Process any incoming args.
        for (int i = 0; i < args.Length; i++)
            Console.WriteLine("Arg: {0}", args[i]);
        Console.ReadLine();
        return -1;
    }
}
