/// <summary>The main class.</summary>
class Chapter_28
{
    static bool Less<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0;
    }

    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        int a = 4, b = 7;
        var c = Less(a, b);
    }
}
