/// <summary>The main class.</summary>
class Chapter_29
{
    const int b = 5;

    static readonly int c = 4;
    readonly int[] e = { 1, 2, 3 };

    int d = 10;

    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        const int a = 10;
        System.Console.WriteLine(a);
        System.Console.WriteLine(c);
    }

    public ref readonly int GetValue()
    {
        return ref d;
    }
}
