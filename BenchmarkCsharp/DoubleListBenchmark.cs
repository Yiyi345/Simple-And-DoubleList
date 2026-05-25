using BenchmarkDotNet.Attributes;
using Co.Edu.Uptc.Csharp.DoubleList;

namespace BenchmarkCsharp;

[MemoryDiagnoser]
public class DoubleListBenchmark
{
    private DoubleList<int> list;

    [GlobalSetup]
    public void Setup()
    {
        list = new DoubleList<int>();

        for (int i = 0; i < 10000; i++)
        {
            list.Add(i);
        }
    }

    [Benchmark]
    public void Add()
    {
        DoubleList<int> temp = new();

        for (int i = 0; i < 10000; i++)
        {
            temp.Add(i);
        }
    }

    [Benchmark]
    public void Contains()
    {
        list.Contains(9999);
    }

    [Benchmark]
    public void Remove()
    {
        DoubleList<int> temp = new();

        for (int i = 0; i < 10000; i++)
        {
            temp.Add(i);
        }

        temp.Remove(5000);
    }
}