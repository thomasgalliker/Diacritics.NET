using System.Diagnostics;

namespace Diacritics.Tests.Import
{
    [DebuggerDisplay("Mapping '{this.Source}' -> '{this.Target}' ({this.Case})")]
    public class AccentsMappingData
    {
        public char Source { get; set; }

        public string Base { get; set; }

        public string Decompose { get; set; }

        public string DecomposeTitle { get; set; }

        public string Case { get; set; }
    }
}
