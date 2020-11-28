using Diacritics.AccentMappings;

namespace Diacritics
{
    public class DefaultDiacriticsMapper : DiacriticsMapper
    {
        public DefaultDiacriticsMapper() : base(
                new AfrikaansAccentsMapping(),
                new ArabicAccentsMapping(),
                new AzerbaijaniAccentsMapping(),
                new BelarusianAccentsMapping(),
                new BosnianAccentsMapping(),
                new BulgarianAccentsMapping(),
                new CatalanAccentsMapping(),
                new CroatianAccentsMapping(),
                new CzechAccentsMapping(),
                new DutchAccentsMapping(),
                new EnglishAccentsMapping(),
                new EstonianAccentsMapping(),
                new FilipinoAccentsMapping(),
                new FrenchAccentsMapping(),
                new GermanAccentsMapping(),
                new GreekAccentsMapping(),
                new HungarianAccentsMapping(),
                new IcelandicAccentsMapping(),
                new ItalianAccentsMapping(),
                new LatvianAccentsMapping(),
                new PolishAccentsMapping(),
                new PortugueseAccentsMapping(),
                new RomanianAccentsMapping(),
                new RussianAccentsMapping(),
                new SlovakianAccentsMapping(),
                new SpanishAccentsMapping(),
                new SwissGermanAccentsMapping(),
                new SwedishAccentsMapping(),
                new TamilAccentsMapping(),
                new TonganAccentsMapping(),
                new TurkishAccentsMapping(),
                new UkarainianAccentsMapping(),
                new UrduAccentsMapping(),
                new VietnameseAccentsMapping(),
                new OtherAccentsMapping())
        {
        }
    }
}