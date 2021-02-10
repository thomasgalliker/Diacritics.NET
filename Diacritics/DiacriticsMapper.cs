using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diacritics.AccentMappings;

namespace Diacritics
{
    public class DiacriticsMapper : IDiacriticsMapper
    {
        private readonly Dictionary<char, string> diacriticsMapping;

        public DiacriticsMapper(params IAccentMapping[] mappings)
        {
            diacriticsMapping = new Dictionary<char, string>();

            if (mappings != null)
            {
                foreach (var accentMapping in mappings.Where(m => m.Mapping != null))
                {
                    //in case of duplicates, the first one wins
                    foreach (var charMapping in accentMapping.Mapping.Where(m => !diacriticsMapping.ContainsKey(m.Key)))
                    {
                        diacriticsMapping.Add(charMapping.Key, charMapping.Value);
                    }
                }
            }
        }

        public IEnumerator<KeyValuePair<char, string>> GetEnumerator()
        {
            return diacriticsMapping.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string RemoveDiacritics(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            var result = new StringBuilder(input.Length);
            var inputLowerCase = input.ToLowerInvariant();

            for (var currentIndex = 0; currentIndex < input.Length; currentIndex++)
            {
                var characterLowerCase = inputLowerCase[currentIndex];
                if (diacriticsMapping.TryGetValue(characterLowerCase, out var diacriticRemovedChar))
                {
                    // If the diacritic character from the input is an uppercase letter,
                    // we also want to have the non-diacritic character to be an uppercase letter.
                    if (char.IsUpper(input[currentIndex]))
                    {
                        diacriticRemovedChar = diacriticRemovedChar.ToUpper();
                    }

                    result.Append(diacriticRemovedChar);
                }
                else
                {
                    result.Append(input[currentIndex]);
                }
            }

            return result.ToString();
        }

        public bool HasDiacritics(string source)
        {
            return source != RemoveDiacritics(source);
        }
    }
}