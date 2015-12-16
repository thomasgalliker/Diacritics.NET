using System;

namespace Diacritics
{
    public static class StaticDiacritics
    {
        static readonly Lazy<IDiacriticsMapper> Implementation = new Lazy<IDiacriticsMapper>(CreateDefaultDiacriticsMapper, System.Threading.LazyThreadSafetyMode.PublicationOnly);

        public static IDiacriticsMapper Current
        {
            get
            {
                return Implementation.Value;
            }
        }

        static IDiacriticsMapper CreateDefaultDiacriticsMapper()
        {
            return new DefaultDiacriticsMapper();
        }
    }
}

