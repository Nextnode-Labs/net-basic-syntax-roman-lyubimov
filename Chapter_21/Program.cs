/// <summary>The main class.</summary>
class Chapter_21
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        StreamReader? sr = null;

        try {
            sr = new StreamReader("invalid.txt");
        } catch (FileNotFoundException ex)
        when (ex.FileName!.Contains(".txt")) {
            System.Console.WriteLine("Missing file: " + ex.FileName);
        }
        finally {
            if (null != sr) {
                sr.Close();
            }
        }
    }
}
