using BenchmarkDotNet.Running;

namespace Diacritics.Benchmark
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<RemoveDiacriticsBenchmark>();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}