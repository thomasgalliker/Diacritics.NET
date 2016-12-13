using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Diacritics.AccentMappings;

namespace Diacritics
{
    public class DiacriticsMapper : IDiacriticsMapper
    {
        private Dictionary<char, char> diacriticsMapping;

        public DiacriticsMapper(params IAccentMapping[] mappings)
        {
            this.UpdateMappings(mappings);
        }

        private void UpdateMappings(IAccentMapping[] mappings)
        {
            this.diacriticsMapping = new Dictionary<char, char>();
            var all = new List<KeyValuePair<char, char>>();

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

        public IEnumerator<KeyValuePair<char, char>> GetEnumerator()
        {
            return this.diacriticsMapping.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public string RemoveDiacritics(string input)
        {
            int startIndex = 0;
            int currentIndex = 0;
            var result = new StringBuilder(input.Length);
            var source = input.ToLower();

            while ((currentIndex = source.IndexOfAny(this.diacriticsMapping.Keys.ToArray(), startIndex)) != -1)
            {
                result.Append(input.Substring(startIndex, currentIndex - startIndex));
                char diacriticChar = source[currentIndex];
                char diacriticRemovedChar = this.diacriticsMapping[diacriticChar];

                // If the diacritic character from the input is an uppercase letter,
                // we also want to have the non-diacritic character to be an uppercase letter.
                if (char.IsUpper(input[currentIndex]))
                {
                    diacriticRemovedChar = char.ToUpper(diacriticRemovedChar);
                }

                result.Append(diacriticRemovedChar);

                startIndex = currentIndex + 1;
            }

            if (startIndex == 0)
            {
                return input;
            }

            result.Append(input.Substring(startIndex));

            return result.ToString();
        }

        public bool HasDiacritics(string source)
        {
            return source != this.RemoveDiacritics(source);
        }
    }
}