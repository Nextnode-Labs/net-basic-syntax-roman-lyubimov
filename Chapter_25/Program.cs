#region Geometry
struct Point {
    public int x;
    public int y;
}
#endregion

#if !Some && !Other
#warning Just test warning
#endif

/// <summary>The main class.</summary>
class Chapter_25
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        var p = new Point() { x = 4, y = 3 };
    }
}
