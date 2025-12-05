using System.Diagnostics;

namespace Diacritics.Tests.Import
{
    [DebuggerDisplay("Mapping '{this.Source}' -> '{this.Decompose}' ({this.Case})")]
    public class AccentsMappingData
    {
        public char Source { get; init; }

        public string? Base { get; init; }

        public string? Decompose { get; init; }

        public string? DecomposeTitle { get; init; }

        public string? Case { get; init; }
    }
}
