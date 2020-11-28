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
        private static Lazy<IDiacriticsMapper> implementation;

        static DiacriticsMapper()
        {
            SetDefaultMapper(CreateDefaultDiacriticsMapper);
        }

        public static IDiacriticsMapper Current => implementation.Value;

        public static void SetDefaultMapper(Func<IDiacriticsMapper> factory)
        {
            implementation = new Lazy<IDiacriticsMapper>(factory, LazyThreadSafetyMode.PublicationOnly);
        }

        private static IDiacriticsMapper CreateDefaultDiacriticsMapper()
        {
            return new DefaultDiacriticsMapper();
        }
        #endregion

        private Dictionary<char, MappingReplacement> diacriticsMapping;

        public DiacriticsMapper(params IAccentMapping[] mappings)
        {
            this.UpdateMappings(mappings);
        }

        private void UpdateMappings(IAccentMapping[] mappings)
        {
            this.diacriticsMapping = new Dictionary<char, MappingReplacement>();
            var all = new List<KeyValuePair<char, MappingReplacement>>();

            if (mappings != null)
            {
                foreach (var accentMapping in mappings)
                {
                    var map = accentMapping.Mapping;
                    all.AddRange(map);
                }
            }

            // Group keys so that duplicates are eliminated
            this.diacriticsMapping = all
                .GroupBy(x => x.Key)
                .ToDictionary(k => k.Key, v => v.First().Value);
        }

        public IEnumerator<KeyValuePair<char, MappingReplacement>> GetEnumerator()
        {
            return this.diacriticsMapping.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public string RemoveDiacritics(string input, DiacriticsOptions options = null)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            var decompose = options?.Decompose ?? false;

            var result = new StringBuilder(input.Length);

            // Replace first character (if available)
            {
                var firstChar = input[0];
                if (this.diacriticsMapping.TryGetValue(firstChar, out var mappingReplacement))
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
                for (var currentIndex = 1; currentIndex < input.Length; currentIndex++)
                {
                    var currentChar = input[currentIndex];
                    if (this.diacriticsMapping.TryGetValue(currentChar, out var mappingReplacement))
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

        public bool HasDiacritics(string source, DiacriticsOptions options = null)
        {
            return source != this.RemoveDiacritics(source, options);
        }
    }
}