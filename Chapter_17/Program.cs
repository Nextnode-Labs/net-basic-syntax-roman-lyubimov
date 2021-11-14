interface IComparable
{
    int Compare(object obj)
    {
        return 0;
    }
}

class Circle : IComparable
{
    public int r = 1;

    public int Compare(object o)
    {
        if (null != o)
        {
            return r - (o as Circle)!.r;
        }

        return 0;
    }
}

/// <summary>The main class.</summary>
class Chapter_17
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World");
    }
}
