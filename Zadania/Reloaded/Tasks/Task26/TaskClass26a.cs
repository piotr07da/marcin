using Reloaded.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task27
{
    public class TaskClass26a
    {
        public void Test()
        {
            var p1 = new Person() { Imie = "PiOtR", Nazwisko = "BeJGer" };
            p1.Imie = p1.Imie[0].ToString().ToUpper() + p1.Imie.Substring(1);
            p1.Nazwisko = p1.Nazwisko[0].ToString().ToUpper() + p1.Nazwisko.Substring(1);
            var p2 = new Person() { Imie = "ZuZAnna", Nazwisko = "rÓŻYCKA" };
            p2.Imie = p2.Imie[0].ToString().ToUpper() + p2.Imie.Substring(1);
            p2.Nazwisko = p2.Nazwisko[0].ToString().ToUpper() + p1.Nazwisko.Substring(1);
            var p3 = new Person() { Imie = "MaRciN", Nazwisko = "BeJger" };
            p3.Imie = p1.Imie[0].ToString().ToUpper() + p3.Imie.Substring(1);
            p3.Nazwisko = p3.Nazwisko[0].ToString().ToUpper() + p3.Nazwisko.Substring(1);
            var p4 = new Person() { Imie = "MagdaLena", Nazwisko = "bejGer" };
            p4.Imie = p1.Imie[0].ToString().ToUpper() + p4.Imie.Substring(1);
            p4.Nazwisko = p4.Nazwisko[0].ToString().ToUpper() + p4.Nazwisko.Substring(1);

            Console.WriteLine("----------- OSOBA 1 -----------");
            Console.WriteLine($"  Imię: {p1.Imie}");
            Console.WriteLine($"  Nazwisko: {p1.Nazwisko}");
            Console.WriteLine("...............................");

            Console.WriteLine("----------- OSOBA 2 -----------");
            Console.WriteLine($"  Imię: {p2.Imie}");
            Console.WriteLine($"  Nazwisko: {p2.Nazwisko}");
            Console.WriteLine("...............................");

            Console.WriteLine("----------- OSOBA 3 -----------");
            Console.WriteLine($"  Imię: {p3.Imie}");
            Console.WriteLine($"  Nazwisko: {p3.Nazwisko}");
            Console.WriteLine("...............................");

            Console.WriteLine("----------- OSOBA 4 -----------");
            Console.WriteLine($"  Imię: {p4.Imie}");
            Console.WriteLine($"  Nazwisko: {p4.Nazwisko}");
            Console.WriteLine("...............................");
        }


    }
}
