using Diacritics.AccentMappings;

namespace Diacritics
{
    public class DefaultDiacriticsMapper : DiacriticsMapper
    {
        public DefaultDiacriticsMapper() : base(
                new ArabicAccentsMapping(),
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
                new TurkishAccentsMapping(),
                new UkarainianAccentsMapping())
        {
        }
    }
}