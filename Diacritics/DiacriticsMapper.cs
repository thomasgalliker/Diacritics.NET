using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Diacritics.AccentMappings;

namespace Diacritics
{
    public class DiacriticsMapper : IDiacriticsMapper
    {
        #region DiacriticsMapper.Current

        private static Lazy<IDiacriticsMapper> Implementation;

        static DiacriticsMapper()
        {
            SetDefaultMapper(CreateDefaultDiacriticsMapper);
        }

        public static IDiacriticsMapper Current => Implementation.Value;

        public static void SetDefaultMapper(Func<IDiacriticsMapper> factory)
        {
            Implementation = new Lazy<IDiacriticsMapper>(factory, LazyThreadSafetyMode.PublicationOnly);
        }

        private static IDiacriticsMapper CreateDefaultDiacriticsMapper()
        {
            return new DefaultDiacriticsMapper();
        }

        #endregion

        private readonly IDictionary<char, MappingReplacement> diacriticsMappings;

        public DiacriticsMapper(params IAccentMapping[] mappings)
        {
            this.diacriticsMappings = ConvertMappings(mappings);
        }

        private static IDictionary<char, MappingReplacement> ConvertMappings(IAccentMapping[] accentMappings)
        {
            var all = new Dictionary<char, MappingReplacement>();

            if (accentMappings != null)
            {
                foreach (var accentMapping in accentMappings)
                {
                    var mappings = accentMapping.Mapping;
                    foreach (var mapping in mappings)
                    {
                        if (!all.TryGetValue(mapping.Key, out var mappingReplacement))
                        {
                            all[mapping.Key] = mapping.Value;
                        }
                        else
                        {
                            // Merge existing DecomposeTitle and Decompose properties,
                            // unless the current mapping replacement defines them.
                            if (mappingReplacement.DecomposeTitle == null)
                            {
                                mappingReplacement.DecomposeTitle = mapping.Value.DecomposeTitle;
                            }

                            if (mappingReplacement.Decompose == null)
                            {
                                mappingReplacement.Decompose = mapping.Value.Decompose;
                            }

                            all[mapping.Key] = mappingReplacement;
                        }
                    }
                }
            }

            // Group keys so that duplicates are eliminated
            return all;
        }

        public IEnumerator<KeyValuePair<char, MappingReplacement>> GetEnumerator()
        {
            return this.diacriticsMappings.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public string RemoveDiacritics(string source)
        {
            return this.RemoveDiacritics(source, options: null);
        }

        public string RemoveDiacritics(string source, DiacriticsOptions options)
        {
            return RemoveDiacritics(source, this.diacriticsMappings, options);
        }

        public string RemoveDiacritics(string source, IAccentMapping[] mappings)
        {
            return this.RemoveDiacritics(source, mappings, options: null);
        }

        public string RemoveDiacritics(string source, IAccentMapping[] mappings, DiacriticsOptions options)
        {
            var diacriticsMappings = ConvertMappings(mappings);
            return RemoveDiacritics(source, diacriticsMappings, options);
        }

        private static string RemoveDiacritics(string source, IDictionary<char, MappingReplacement> diacriticsMappings, DiacriticsOptions options)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return source;
            }

            var decompose = options?.Decompose ?? false;

            var result = new StringBuilder(source.Length);

            // Replace first character (if available)
            {
                var firstChar = source[0];

                if (diacriticsMappings.TryGetValue(firstChar, out var mappingReplacement))
                {
                    if (decompose)
                    {
                        result.Append(mappingReplacement.DecomposeTitle);
                    }
                    else
                    {
                        result.Append(mappingReplacement.Base);
                    }
                }
                else
                {
                    result.Append(firstChar);
                }
            }

            // Replace characters N+1
            {
                for (var currentIndex = 1; currentIndex < source.Length; currentIndex++)
                {
                    var currentChar = source[currentIndex];

                    if (diacriticsMappings.TryGetValue(currentChar, out var mappingReplacement))
                    {
                        if (decompose)
                        {
                            result.Append(mappingReplacement.Decompose);
                        }
                        else
                        {
                            result.Append(mappingReplacement.Base);
                        }
                    }
                    else
                    {
                        result.Append(currentChar);
                    }
                }
            }

            return result.ToString();
        }

        public bool HasDiacritics(string source)
        {
            return this.HasDiacritics(source, options: null);
        }

        public bool HasDiacritics(string source, DiacriticsOptions options)
        {
            return source != this.RemoveDiacritics(source, options);
        }
    }
}