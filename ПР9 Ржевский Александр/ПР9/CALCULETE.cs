using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР9
{
    struct Countries
    {
        public string CountryName { get; set; }
        public string Population { get; set; }
        public string Capital { get; set; }
        public string MonetaryUnit { get; set; }

        public Countries(string countryName, string population, string capital, string monetaryUnit)
        {
            CountryName = countryName;
            Population = population;
            Capital = capital;
            MonetaryUnit = monetaryUnit;
        }

    }
}