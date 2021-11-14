/// <summary>The main class.</summary>
class Chapter_9
{
    public int m_field = 5;

    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        Chapter_9 app = new Chapter_9();

        int x = 0;
        app.SetValueByRef(ref x);

        ref int fieldRef = ref app.GetMyPublicFieldByRef();
        fieldRef = 10;

        int y;
        app.InitVar(out y);

        int t = 10;
        Recursion(t);
        System.Console.WriteLine("Done");
        void Recursion(int i)
        {
            if (i <= 0) return;
            System.Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // wait 1 second
            Recursion(i - 1);
        }
    }

    public void SetValueByRef(ref int i)
    {
        i = 10;
    }

    public ref int GetMyPublicFieldByRef()
    {
        return ref m_field;
    }

    public void InitVar(out int y)
    {
        y = 15;
    }
}
