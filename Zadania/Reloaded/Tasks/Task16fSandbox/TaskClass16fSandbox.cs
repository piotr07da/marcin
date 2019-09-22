using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Reloaded.Tasks.Task16fSandbox
{
    public class TaskClass16fSandbox
    {
        private readonly CountriesRestApiClient _apiClient;
        private readonly ICountriesSearchReportWriter _countriesSearchReportWriter; //co to za zmienna

        public TaskClass16fSandbox(int x, int y, int z, string message, ICountriesSearchReportWriter countriesSearchReportWriter) //czemu tu jest w nawiasach
        {
            Console.WriteLine(message);

            _apiClient = new CountriesRestApiClient();
            _countriesSearchReportWriter = countriesSearchReportWriter;
        }

        public async Task Test()
        {
            try // próbujemy wykonać kod w klamrach
            {
                Console.WriteLine("Szukaj państwa (nazwa po angielsku, nie trzeba wpisywać całej nazwy - można np. tylko pierwszą literę):");
                var searchText = Console.ReadLine();

                var countries = await _apiClient.GetCountries(searchText);
                List<CountryDto> countries2 = new List<CountryDto>();
                               
                foreach (var country in countries)
                {                    
                    var tempCountry = country.Name.ToUpper();
                    var tempSearch = searchText.ToUpper();

                    if (tempCountry.Contains(tempSearch))
                    {
                        countries2.Add(country);
                    }
                                   
                }
                //...

                _countriesSearchReportWriter.Write(countries);
            }
            catch (Exception ex) // jeżeli się nie uda bo z jakiejś przyczyny poleciał wyjątek...
            {
                // ... to wypisujemy ten wyjątek na konsolę:
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
