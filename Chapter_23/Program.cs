class MyInt
{
    public int val;

    public MyInt(int val) { this.val = val; }

    public static implicit operator MyInt(int val)
    {
        return new MyInt(val);
    }

    public static explicit operator int(MyInt a)
    {
        return a.val;
    }

    public static MyInt operator +(MyInt a, MyInt b)
    {
        return new MyInt(a.val + b.val);
    }
}

/// <summary>The main class.</summary>
class Chapter_23
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        MyInt a = 5;
        int b = 4;

        int c = (int)(a + b);
    }
}
