class Time {
    private int seconds;
    public int sec
    {
        get { return seconds; }
        set { seconds = value; }
    }

    public System.DateTime Created { get; } = System.DateTime.Now;
}


/// <summary>The main class.</summary>
class Chapter_15
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        Time t = new Time();
        t.sec = 5;
        int s = t.sec; // 5

        System.Console.WriteLine(t.Created);
    }
}
