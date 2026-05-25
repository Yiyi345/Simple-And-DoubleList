using BenchmarkDotNet.Attributes;
using Co.Edu.Uptc.Csharp.SimpleList;

namespace BenchmarkCsharp;

[MemoryDiagnoser]
public class SimpleListBenchmark
{
    private SimpleList<int> list;

    [GlobalSetup]
    public void Setup()
    {
        list = new SimpleList<int>();

        for (int i = 0; i < 10000; i++)
        {
            list.Add(i);
        }
    }

    [Benchmark]
    public void Add()
    {
        SimpleList<int> temp = new();

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
        SimpleList<int> temp = new();

        for (int i = 0; i < 10000; i++)
        {
            temp.Add(i);
        }

        temp.Remove(5000);
    }
}