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

    public virtual bool isSquare()
    {
        return x == y;
    }
}

sealed class Square : Rectangle 
{
    public new int ComputeArea()
    {
        return 2 * x;
    }

    public override bool isSquare()
    {
        return true;
    }
}

sealed class Triangle : Rectangle
{
    public new int ComputeArea()
    {
        return base.ComputeArea() / 2;
    }
}

/// <summary>The main class.</summary>
class Chapter_12
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        // Do nothing
    }
}
