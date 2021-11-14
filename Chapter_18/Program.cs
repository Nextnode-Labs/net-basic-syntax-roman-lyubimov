abstract class Shape
{
    public abstract float GetArea();
}

class Circle : Shape
{
    public float r = 1.0f;

    public override float GetArea()
    {
        return (float)System.Math.PI * r * r;
    }
}

class Square : Shape
{
    public float x = 1.0f;

    public override float GetArea()
    {
        return x * x;
    }
}

/// <summary>The main class.</summary>
class Chapter_18
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World");
    }
}
