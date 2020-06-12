using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agilious_CurrencyConveter
{
    public class ConversionModel
    {
        public rates Rate { get; set; }
        public class rates
        {
            public int CAD { get; set; } // Canada_North America
            public int MXN { get; set; } // Mexico_North America
            public int HKD { get; set; } // Hong Kong_Asia
            public int PHP { get; set; } // Philippines_Asia
            public int IDR { get; set; } // Indonesia_Asia
            public int INR { get; set; } // India_Asia
            public int JPY { get; set; } // Japan_Asia
            public int THB { get; set; } // Thailand_Asia
            public int MYR { get; set; } // Malaysia_Asia
            public int SGD { get; set; } // Singapore_Asia
            public int CNY { get; set; } // China_Asia
            public int KRW { get; set; } // South Korea_Asia
            public int ILS { get; set; } // Israel_Asia
            public int RUB { get; set; } // Russia_Europe/Asia
            public int ISK { get; set; } // Iceland_Europe
            public int EUR { get; set; } // Europe
            public int DKK { get; set; } // Denmark_Europe
            public int HUF { get; set; } // Hungary_Europe
            public int CZK { get; set; } // Czech Republic_Europe
            public int GBP { get; set; } // Great Britain_Europe
            public int RON { get; set; } // Romania_Europe
            public int SEK { get; set; } // Sweden_Europe
            public int HRK { get; set; } // Croatia_Europe
            public int PLN { get; set; } // Poland_Europe
            public int CHF { get; set; } // Switzerland_Europe
            public int BGN { get; set; } // Bulgaria_Europe
            public int TRY { get; set; } // Turkey_Europe
            public int NOK { get; set; } // Norway_Europe
            public int NZD { get; set; } // New Zealand_Austrailia_Asia
            public int AUD { get; set; } // Austrailia

            
        }

        public DateTime date { get; set; }

    }
}