namespace Diacritics
{
    using System;
    using System.Threading;

    public static class StaticDiacritics
    {
        private static Lazy<IDiacriticsMapper> implementation;

        static StaticDiacritics()
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
    }
}