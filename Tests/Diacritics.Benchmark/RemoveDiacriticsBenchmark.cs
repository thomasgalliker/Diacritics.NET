using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Exporters.Csv;

namespace Diacritics.Benchmark
{
	[ShortRunJob]
	[CsvExporter(CsvSeparator.Comma)]
	[RankColumn]
    [MemoryDiagnoser]
	public class RemoveDiacriticsBenchmark
	{
        private static readonly Assembly Assembly = Assembly.GetExecutingAssembly();
        private static readonly IResourceLoader ResourceLoader = System.Reflection.ResourceLoader.Current;
        private static readonly IDiacriticsMapper DiacriticsMapper = IDiacriticsMapper.Current;

        private string loremIpsum100K;
        private string loremIpsum1M;

        [GlobalSetup]
		public void Setup()
		{
            this.loremIpsum100K = ResourceLoader.GetEmbeddedResourceString(Assembly, "LoremIpsum100k.txt");
            this.loremIpsum1M = ResourceLoader.GetEmbeddedResourceString(Assembly, "LoremIpsum1m.txt");
		}

		[Benchmark]
		public string RemoveDiacritics_100kWords()
        {
            return DiacriticsMapper.RemoveDiacritics(this.loremIpsum100K);
        }

		[Benchmark]
		public string RemoveDiacritics_1mWords()
        {
            return DiacriticsMapper.RemoveDiacritics(this.loremIpsum1M);
        }
    }
}
