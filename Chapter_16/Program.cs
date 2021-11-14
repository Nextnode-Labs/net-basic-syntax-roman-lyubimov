class MyVector 
{
    object[] items = new object[10];

    public object this[string s]
    {
        get { return this[Int32.Parse(s)]; }
    }

    public object this[int i]
    {
        get { return items[i]; }
        set { items[i] = value; }
    }
}

class MyMatrix
{
    object[,] data = new object[10, 10];

    public object this[int i, int j]
    {
        get { return data[i, j]; }
        set { data[i, j] = value; }
    }
}

/// <summary>The main class.</summary>
class Chapter_16
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        var v1 = new MyVector();
        v1[5] = "Hello World";
        v1[6] = "Bye!";
        System.Console.WriteLine(v1[5]);
        System.Console.WriteLine(v1["6"]);

        var m1 = new MyMatrix();
        m1[4, 3] = "Hello World";
        System.Console.WriteLine(m1[4, 3]);

        int[] b = { 1, 2, 3, 4, 5 };

        foreach (int n in b[1..3])
        {
            System.Console.Write(n);
        }

        System.Console.WriteLine();

        var range = 0..3;

        foreach (int n in b[range])
        {
            System.Console.Write(n);
        }

        System.Console.WriteLine();

        string s = "welcome";
        System.Index first = 0;
        System.Index last = ^1;
        System.Console.Write($"{s[first]}, {s[last]}"); // "w, e"

        System.Console.WriteLine();

        System.Console.Write(s[^4..]); // "come"
    }
}
