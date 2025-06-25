using BenchmarkDotNet.Running;
using Diacritics.Benchmark;

namespace Diacritical.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<RemoveDiacriticsBenchmark>();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}