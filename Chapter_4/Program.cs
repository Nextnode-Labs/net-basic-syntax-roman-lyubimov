/// <summary>The main class.</summary>
class Chapter_4
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello");

        sb.Append(" World");
        sb.Remove(0, 5);
        sb.Insert(0, "Bye");

        System.Console.WriteLine(sb);
    }
}
