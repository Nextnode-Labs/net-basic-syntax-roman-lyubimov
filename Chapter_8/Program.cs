/// <summary>The main class.</summary>
class Chapter_8
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        int i = 0;

        while (i < 10) {
            System.Console.WriteLine(i++); // 0-9
        }

        int j = 0; 
        
        do {
            System.Console.WriteLine(j++); // 0-9
        } while (j < 10);

        for (int k = 0, m = 5; k < 10; k++, m--) {
            System.Console.WriteLine(k+m); // 5 (10x)
        }

        int[] a = { 1, 2, 3 };

        foreach (int n in a) {
            System.Console.WriteLine(n); // "123"
        }

        for (int p = 0; p < 10; p++) {
            if (p == 5) break; // end loop
            if (p == 3) continue; // start next iteration
            System.Console.WriteLine(p); // "0124"
        }
    }
}
