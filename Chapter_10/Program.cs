class Rectangle {
    public int x;
    public int y;

    public Rectangle()
    {
        x = 10;
        y = 10;
    }

    public Rectangle(int t) : this(t, t)
    {
    }

    public Rectangle(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    ~Rectangle()
    {
        // Do nothing
    }

    public int ComputeArea() 
    {
        return x * y;
    }
}

/// <summary>The main class.</summary>
class Chapter_10
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        var r1 = new Rectangle();
        var r2 = new Rectangle { x = 15, y = 15 };

        Rectangle? r3 = null;

        int? a = r3?.ComputeArea();

        r3 ??= new Rectangle();
    }
}
