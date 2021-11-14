class Circle
{
    public float r = 10f;

    public static float pi = 3.14f;

    public float GetArea()
    {
        return ComputeArea(r);
    }

    public static float ComputeArea(float a)
    {
        return pi * a * a;
    }
}

class StaticClass
{
    public static int magicNum = 5;

    static StaticClass()
    {
        // Will override value
        magicNum = 10;
    }
}

static class Extension
{
    public static float GetDiameter(this Circle c)
    {
        return c.r * 2.0f;
    }
}

/// <summary>The main class.</summary>
class Chapter_14
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        float f = Circle.ComputeArea(Circle.pi);

        var c = new Circle();

        System.Console.WriteLine(StaticClass.magicNum);
        System.Console.WriteLine(c.GetDiameter());
    }
}
