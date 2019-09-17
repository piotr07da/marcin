using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16fSandbox
{
    public class FileCountriesSearchReportWriter : ICountriesSearchReportWriter
    {
        public void Write(CountryDto[] foundCountries)
        {
            string rep = "";
            foreach (var country in foundCountries)
            {
                rep += " " + country.Name + " ";
            }
            File.WriteAllText("countries-rep.txt", rep);
        }
    }
}
