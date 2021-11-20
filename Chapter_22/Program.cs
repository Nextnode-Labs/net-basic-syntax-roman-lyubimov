class MyInt
{
    public int val;

    public MyInt(int val) { this.val = val; }
    public static MyInt operator +(MyInt a, MyInt b)
    {
        return new MyInt(a.val + b.val);
    }
}

/// <summary>The main class.</summary>
class Chapter_22
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        var a = new MyInt(10);
        var b = new MyInt(5);

        var c = a + b;
    }
}
