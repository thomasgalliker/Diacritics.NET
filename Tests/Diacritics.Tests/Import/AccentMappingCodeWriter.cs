using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Diacritics.Tests.Import
{
    /// <summary>
    /// Generates the C# source code of an <see cref="Diacritics.AccentMappings.IAccentMapping"/> implementation.
    /// </summary>
    internal static class AccentMappingCodeWriter
    {
        /// <summary>
        /// The source folder of the accent mappings in the Diacritics project.
        /// </summary>
        public static readonly string AccentMappingsFolder = Path.GetFullPath(
            Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "Diacritics", "AccentMappings"));

        /// <summary>
        /// Generates a partial class named <paramref name="className"/> which contains the given <paramref name="mappings"/>.
        /// </summary>
        /// <param name="className">The name of the generated class.</param>
        /// <param name="mappings">The mappings to be written, in the order in which they should appear.</param>
        /// <param name="summary">Optional XML documentation summary of the generated class.</param>
        public static string Generate(string className, IEnumerable<AccentsMappingData> mappings, string? summary = null)
        {
            var mappingsDump = string.Join($",{Environment.NewLine}", mappings.Select(FormatMapping));
            var classDocumentation = summary != null
                ? $"    /// <summary>{Environment.NewLine}    /// {summary}{Environment.NewLine}    /// </summary>{Environment.NewLine}"
                : string.Empty;

            var content = @$"using System.Collections.Generic;

namespace Diacritics.AccentMappings
{{
{classDocumentation}    public partial class {className} : IAccentMapping
    {{
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {{
{mappingsDump}
        }};

        public IDictionary<char, MappingReplacement> Mapping {{ get {{ return MappingDictionary; }} }}
    }}
}}";

            return content;
        }

        private static string FormatMapping(AccentsMappingData m)
        {
            var source = ToCharLiteral(m.Source);

            if (m.Base != null && m.Decompose == null && m.DecomposeTitle == null)
            {
                // Base-only mappings use the implicit string conversion of MappingReplacement
                return $"\t\t\t{{ {source}, {ToStringLiteral(m.Base)} }}";
            }

            var paramBase = ToStringLiteral(m.Base);
            var paramDecompose = ToStringLiteral(m.Decompose);
            var paramDecomposeTitle = ToStringLiteral(m.DecomposeTitle);
            return $"\t\t\t{{ {source}, new MappingReplacement({paramBase}, {paramDecompose}, {paramDecomposeTitle}) }}";
        }

        private static string ToCharLiteral(char c)
        {
            return c switch
            {
                '\'' => @"'\''",
                '\\' => @"'\\'",
                _ when IsInvisible(c) => $"'\\u{(int)c:X4}'",
                _ => $"'{c}'",
            };
        }

        private static string ToStringLiteral(string? value)
        {
            if (value == null)
            {
                return "null";
            }

            var sb = new StringBuilder(value.Length + 2);
            sb.Append('"');
            foreach (var c in value)
            {
                switch (c)
                {
                    case '"':
                        sb.Append("\\\"");
                        break;
                    case '\\':
                        sb.Append(@"\\");
                        break;
                    default:
                        if (IsInvisible(c))
                        {
                            sb.Append($"\\u{(int)c:X4}");
                        }
                        else
                        {
                            sb.Append(c);
                        }

                        break;
                }
            }

            sb.Append('"');
            return sb.ToString();
        }

        /// <summary>
        /// Combining marks and control/format characters are written as \uXXXX escapes,
        /// since they would be invisible or attach to the surrounding quotes in source code.
        /// </summary>
        private static bool IsInvisible(char c)
        {
            var category = CharUnicodeInfo.GetUnicodeCategory(c);
            return category is UnicodeCategory.NonSpacingMark
                or UnicodeCategory.SpacingCombiningMark
                or UnicodeCategory.EnclosingMark
                or UnicodeCategory.Format
                or UnicodeCategory.Control;
        }
    }
}
