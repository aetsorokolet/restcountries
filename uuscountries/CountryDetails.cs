using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace uuscountries
{
    class CountryDetails
    {
        
        public class Language
        {
            public string Name { get; set; }
        }

        public class Country
        {
            public string Name { get; set; }

            public string Capital { get; set; }

            public string Region { get; set; }

            public string Cioc { get; set; }

            public int Population { get; set; }

            public List<string> TopLevelDomain { get; set; }

            public List<Language> Languages { get; set; }
        }
    }   
}

