using System;
using System.Threading;

namespace Diacritics
{
    [Obsolete("Use DiacriticsMapper instead")]
    public static class StaticDiacritics
    {
        private static Lazy<IDiacriticsMapper> implementation;

        static StaticDiacritics()
        {
            SetDefaultMapper(CreateDefaultDiacriticsMapper);
        }

        [Obsolete("Use DiacriticsMapper.Current instead")]
        public static IDiacriticsMapper Current => implementation.Value;
        
        [Obsolete("Use DiacriticsMapper.SetDefaultMapper instead")]
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