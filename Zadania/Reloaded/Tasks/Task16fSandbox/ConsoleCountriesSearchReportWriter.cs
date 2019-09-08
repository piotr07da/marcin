using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16fSandbox
{
    // konsolowy zapisywacz raportu wyszukiwania państw
    public class ConsoleCountriesSearchReportWriter
    {
        public void Write(CountryDto[] foundCountries) // zapis raportu na konsolę
        {
            Console.WriteLine("Odanelziono następujące państwa:");

            foreach (var country in foundCountries)
            {
                Console.WriteLine($"- {country.Name} ze stolicą w {country.Capital}.");
                Console.WriteLine($"  - ludność: {country.Population / 1e6} milionów");
                Console.WriteLine($"  - powierzchnia: {country.Area} km^2");
            }
        }
    }
}
