using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

public class Sleeps
{
    [Benchmark]
    public void Countto100()
    {
        for (var i=1;i<=100;i++)
        {
            System.Threading.Thread.Sleep(10);
        }
    }

    [Benchmark]
    public void CountTo200()
    {
        for (var i=1;i<=200;i++)
        {
            System.Threading.Thread.Sleep(10);
        }
    }
}