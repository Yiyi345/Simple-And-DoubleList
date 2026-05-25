using BenchmarkDotNet.Running;

namespace BenchmarkCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<DoubleListBenchmark>();
        }
    }
}