namespace Diacritics
{
    public class DiacriticsOptions
    {
        /// <summary>
        /// Indicates if the <see cref="MappingReplacement.Base"/> value or <see cref="MappingReplacement.Decompose"/> should be used.
        /// This option is only relevant for accent mappings which have <see cref="MappingReplacement.Decompose"/> values defined (e.g. <see cref="Diacritics.AccentMappings.GermanAccentsMapping"/>).
        /// </summary>
        public bool Decompose { get; set; }
    }
}