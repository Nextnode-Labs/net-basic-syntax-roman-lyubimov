public delegate void EventHandler(object sender, System.EventArgs e);

class Publisher
{
    public event EventHandler? Published;

    public void Notify()
    {
        if (null != Published) {
            Published(this, System.EventArgs.Empty);
        }
    }
}

/// <summary>The main class.</summary>
class Chapter_27
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        var f = (object sender, System.EventArgs e) => System.Console.WriteLine("Published!");
        var k = delegate (object sender, System.EventArgs e) 
        {
            System.Console.WriteLine("Published");
        };

        var p = new Publisher();

        p.Published += new EventHandler(k);
        p.Published += new EventHandler(f);
        p.Notify();
    }
}
