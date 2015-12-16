using Diacritics.AccentMappings;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diacritics
{
    public class DiacriticsMapper : IEnumerable<KeyValuePair<char, char>>, IDiacriticsMapper
    {
        private Dictionary<char, char> diacriticsMapping;

        public DiacriticsMapper(params IAccentMapping[] mappings)
        {
            this.UpdateMappings(mappings);
        }

        protected void UpdateMappings(IAccentMapping[] mappings)
        {
            this.diacriticsMapping = new Dictionary<char, char>();
            var all = new List<KeyValuePair<char, char>>();

            if (mappings != null)
            {
                foreach (var accentMapping in mappings)
                {
                    var map = accentMapping.GetMapping();
                    //PrintDictionary(map, accentMapping.GetType().Name);
                    all.AddRange(map);
                }
            }

            // Group keys so that duplicates are eliminated
            this.diacriticsMapping = all.GroupBy(x => x.Key).ToDictionary(k => k.Key, v => v.First().Value);
        }

        //TODO GATH: TO be used for a performance improvement. Zip (Linq) can be eliminated.
        ////private static void PrintDictionary(Dictionary<char, char> dict, string name)
        ////{
        ////    StringBuilder sb = new StringBuilder();
        ////    sb.AppendLine(string.Format("var {0} = new Dictionary<char, char>", name));
        ////    sb.AppendLine("{");
        ////    foreach (var d in dict)
        ////    {
        ////        sb.AppendLine(string.Format("{{ '{0}', '{1}' }},", d.Key, d.Value));
        ////    }
        ////    sb.AppendLine("};");

        ////    Debug.WriteLine(sb.ToString());
        ////}

        public IEnumerator<KeyValuePair<char, char>> GetEnumerator()
        {
            return this.diacriticsMapping.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public string RemoveDiacritics(string source)
        {
            int startIndex = 0;
            int currentIndex = 0;
            var result = new StringBuilder(source.Length);

            while ((currentIndex = source.IndexOfAny(this.diacriticsMapping.Keys.ToArray(), startIndex)) != -1)
            {
                result.Append(source.Substring(startIndex, currentIndex - startIndex));
                result.Append(this.diacriticsMapping[source[currentIndex]]);

                startIndex = currentIndex + 1;
            }

            if (startIndex == 0)
            {
                return source;
            }

            result.Append(source.Substring(startIndex));

            return result.ToString();
        }

        public bool HasDiacritics(string source)
        {
            return source != this.RemoveDiacritics(source);
        }
    }

    public interface IDiacriticsMapper
    {
        string RemoveDiacritics(string source);

        bool HasDiacritics(string source);
    }
}