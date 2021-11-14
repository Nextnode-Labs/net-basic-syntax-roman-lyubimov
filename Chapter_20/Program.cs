enum State : long
{ 
    Run = 2, 
    Wait = Run -1, 
    Stop = 0
};

/// <summary>The main class.</summary>
class Chapter_20
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        State st = State.Run;

        switch (st)
        {
            case State.Run:
                System.Console.WriteLine("Running");
                break;
            case State.Wait:
                System.Console.WriteLine("Waiting");
                break;
            case State.Stop:
                System.Console.WriteLine("Stopped");
                break;
        }

        System.Console.WriteLine();

        foreach (string s in System.Enum.GetNames(typeof(State)))
        {
            System.Console.WriteLine(s);
        }
    }
}
