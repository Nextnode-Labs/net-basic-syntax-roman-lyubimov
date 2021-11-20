using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

/// <summary>The main class.</summary>
class Chapter_30
{
    Task<string> GetHelloWorld()
    {
        return Task.Run<string>(() => {
            Thread.Sleep(200);
            return "Hello World";
        });
    }

    async IAsyncEnumerable<int> Generate(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return i;

            await Task.Delay(200);
        }
    }

    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static async Task Main(string[] args)
    {
        var c = new Chapter_30();
        var r = await c.GetHelloWorld();
        System.Console.WriteLine(r);

        await foreach (int v in c.Generate(3))
        {
            System.Console.WriteLine(v);
        }
    }
}
