using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class JapaneseAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, MappingReplacement> MappingDictionary = new Dictionary<char, MappingReplacement>
        {
			{ 'が', "か" },
			{ 'ぎ', "き" },
			{ 'ぐ', "く" },
			{ 'げ', "け" },
			{ 'ご', "こ" },
			{ 'ざ', "さ" },
			{ 'じ', "し" },
			{ 'ず', "す" },
			{ 'ぜ', "せ" },
			{ 'ぞ', "そ" },
			{ 'だ', "た" },
			{ 'ぢ', "ち" },
			{ 'づ', "つ" },
			{ 'で', "て" },
			{ 'ど', "と" },
			{ 'ば', "は" },
			{ 'ぱ', "は" },
			{ 'び', "ひ" },
			{ 'ぴ', "ひ" },
			{ 'ぶ', "ふ" },
			{ 'ぷ', "ふ" },
			{ 'べ', "へ" },
			{ 'ぺ', "へ" },
			{ 'ぼ', "ほ" },
			{ 'ぽ', "ほ" },
			{ 'ゞ', "ゝ" },
			{ 'ガ', "カ" },
			{ 'ギ', "キ" },
			{ 'グ', "ク" },
			{ 'ゲ', "ケ" },
			{ 'ゴ', "コ" },
			{ 'ザ', "サ" },
			{ 'ジ', "シ" },
			{ 'ズ', "ス" },
			{ 'ゼ', "セ" },
			{ 'ゾ', "ソ" },
			{ 'ダ', "タ" },
			{ 'ヂ', "チ" },
			{ 'ヅ', "ツ" },
			{ 'デ', "テ" },
			{ 'ド', "ト" },
			{ 'バ', "ハ" },
			{ 'パ', "ハ" },
			{ 'ビ', "ヒ" },
			{ 'ピ', "ヒ" },
			{ 'ブ', "フ" },
			{ 'プ', "フ" },
			{ 'ベ', "ヘ" },
			{ 'ペ', "ヘ" },
			{ 'ボ', "ホ" },
			{ 'ポ', "ホ" },
			{ 'ヴ', "ウ" },
			{ 'ヾ', "ヽ" }
        };

        public IDictionary<char, MappingReplacement> Mapping { get { return MappingDictionary; } }
    }
}