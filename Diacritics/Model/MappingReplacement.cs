namespace Diacritics
{
    public struct MappingReplacement
    {
        public MappingReplacement(string @base, string decompose, string decomposeTitle) : this()
        {
            this.Base = @base;
            this.Decompose = decompose;
            this.DecomposeTitle = decomposeTitle;
        }

        public string Base { get; set; }

        public string Decompose { get; set; }

        public string DecomposeTitle { get; set; }
    }
}
