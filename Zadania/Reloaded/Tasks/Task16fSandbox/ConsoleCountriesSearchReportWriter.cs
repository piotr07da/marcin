using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16fSandbox
{
    // konsolowy zapisywacz raportu wyszukiwania państw
    public class ConsoleCountriesSearchReportWriter : ICountriesSearchReportWriter
    {
        public void Write(CountryDto[] foundCountries) // zapis raportu na konsolę
        {
            Console.WriteLine("Odanelziono następujące państwa:");

            foreach (var country in foundCountries)
            {
                country.Name = country.Name.ToUpper();
                Console.WriteLine($"-{country.Name}");
                Console.WriteLine($"  - stolica {country.Capital}");
                Console.WriteLine($"  - ludność: {country.Population / 1e6} milionów");
                Console.WriteLine($"  - powierzchnia: {country.Area} km^2");
                Console.WriteLine($"  - gęstość zaludnienia: {country.Population/country.Area}");
                Console.WriteLine($"  - szerokość geograficzna {country.LatLng[0]}");
                Console.WriteLine($"  - długość geograficzna {country.LatLng[1]}");
                Console.WriteLine($"  - ISO {country.Alpha3Code}");
            }
        }
    }
}
