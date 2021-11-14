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

class Square : Rectangle {}

/// <summary>The main class.</summary>
class Chapter_11
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        Square s = new Square();
        Rectangle r = s;

        int a = 10;

        object objBox = a;

        int b = (int)objBox;

        if (r is Square) {
            Square o = (Square)r;
        }

        switch (objBox) {
            case 5:
                System.Console.WriteLine("5");
                break;
            case int i:
                System.Console.WriteLine("int:" + i);
                break;
            case null:
                System.Console.WriteLine("null");
                break;
        }
    }
}
