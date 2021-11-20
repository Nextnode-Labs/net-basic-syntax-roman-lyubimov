delegate void MyFunction(string str);
delegate int Mul(int a, int b);

/// <summary>The main class.</summary>
class Chapter_26
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        MyFunction d = Print;
        d("Hello World");

        MyFunction f = delegate(string str)
        {
            System.Console.WriteLine(str);
        };

        f("Bye");

        MyFunction pub = d + f;

        pub("Some");

        Mul mul = (a, b) => a * b;

        mul(5, 10);
    }

    static void Print(string str)
    {
        System.Console.WriteLine(str);
    }
}
