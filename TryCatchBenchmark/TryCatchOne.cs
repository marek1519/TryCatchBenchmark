using BenchmarkDotNet.Attributes;

namespace TryCatchBenchmark;

[MemoryDiagnoser]
public class TryCatchOne
{
    [Benchmark]
    public void DoSomethingSingle()
    {
        for (double i = 0; i < 1000; i++)
        {
            DoSomethingSingle(i);
        }
    }

    public void DoSomethingSingle(double lp)
    {
        try
        {
            var l = lp / lp;
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
    
    [Benchmark]
    public void DoSomething()
    {
        try
        {
            for (double i = 1000; i >= 0; i--)
            {
                DoSomething(i);
            }
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }

    public void DoSomething(double lp)
    {
        var l = lp / lp;
    }
}