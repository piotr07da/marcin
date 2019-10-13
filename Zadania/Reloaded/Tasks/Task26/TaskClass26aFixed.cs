using System;
using Reloaded.Examples;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task26
{
    public class TaskClass26aFixed
    {
        
        public void Test()
        {
            
            var p1 = new Person() { Imie = "PiOtR", Nazwisko = "BeJGer" };
            CreatePerson(p1);

            var p2 = new Person() { Imie = "ZuZAnna", Nazwisko = "rÓŻYCKA" };
            CreatePerson(p2);

            var p3 = new Person() { Imie = "MaRciN", Nazwisko = "BeJger" };
            CreatePerson(p3);

            var p4 = new Person() { Imie = "MagdaLena", Nazwisko = "bejGer" };
            CreatePerson(p4);

            ShowPersonData(p1,1);
            ShowPersonData(p2,2);
            ShowPersonData(p3,3);
            ShowPersonData(p4,4);

          
            Console.ReadKey();
        }
        private void CreatePerson(Person p)
        {
            
            p.Imie = p.Imie[0].ToString().ToUpper() + p.Imie.Substring(1).ToLower();
            p.Nazwisko = p.Nazwisko[0].ToString().ToUpper() + p.Nazwisko.Substring(1).ToLower();
        }
        private void ShowPersonData(Person p,int i)
        {
            Console.WriteLine($"----------- OSOBA {i} -----------");
            Console.WriteLine($"  Imię: {p.Imie}");
            Console.WriteLine($"  Nazwisko: {p.Nazwisko}");
            Console.WriteLine("...............................");
        }
    }
}

       


    

