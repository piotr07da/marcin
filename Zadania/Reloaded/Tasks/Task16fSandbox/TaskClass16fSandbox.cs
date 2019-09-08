using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16fSandbox
{
    public class TaskClass16fSandbox
    {
        private readonly CountriesRestApiClient _apiClient;
        private readonly ConsoleCountriesSearchReportWriter _countriesSearchReportWriter;

        public TaskClass16fSandbox()
        {
            _apiClient = new CountriesRestApiClient();
            _countriesSearchReportWriter = new ConsoleCountriesSearchReportWriter();
        }

        public async Task Test()
        {
            try // próbujemy wykonać kod w klamrach
            {
                Console.WriteLine("Szukaj państwa (nazwa po angielsku, nie trzeba wpisywać całej nazwy - można np. tylko pierwszą literę):");
                var searchText = Console.ReadLine();

                var countries = await _apiClient.GetCountries(searchText);

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
