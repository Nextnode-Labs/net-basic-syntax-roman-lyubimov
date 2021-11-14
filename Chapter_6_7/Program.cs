/// <summary>The main class.</summary>
class Chapter_6_7
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        // Get a random integer (0, 1 or 2)
        int x = new System.Random().Next(3);

        if (x < 1) {
            System.Console.WriteLine(x + " < 1");
        } else if (x > 1) {
            System.Console.WriteLine(x + " > 1");
        } else {
            System.Console.WriteLine(x + " == 1");
        }

        x = new System.Random().Next(4);

        switch (x)
        {
            case 0: 
                System.Console.WriteLine(x + " is 0"); 
                break;
            case 1: 
                System.Console.WriteLine(x + " is 1"); 
                break;
            default:
                System.Console.WriteLine(x + " is >1"); 
                break;
        }

        x = new System.Random().Next(4);

        string result = x switch {
            0 => "zero",
            1 => "one",
            _ => "more than one"
        };

        System.Console.WriteLine("x is " + result);

        // Get a number between 0.0 and 1.0
        double z = new System.Random().NextDouble();
        z = (x < 0.5) ? 0 : 1; // ternary operator (?:)
    }
}
