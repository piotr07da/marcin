using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace Reloaded.Tasks.Task21
{
    public class TaskClass21
    {
        public void Test()
        {
            var dateOfBirth1 = new DateTime(1982, 03, 13);
            var person1 = new Person("Pietia", "Goros", dateOfBirth1, Person.ESex.Male);

            var dateOfBirth2 = new DateTime(1873, 4, 5);
            var person2 = new Person("Biedia", "Nimojajec", dateOfBirth2, Person.ESex.Male);

            var dateOfBirth3 = new DateTime(1970, 01, 13);
            var person3 = new Person("Barbara", "Liskov", dateOfBirth3, Person.ESex.Female);

            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);

            string json = JsonConvert.SerializeObject(people);
            Console.WriteLine(json);
            File.WriteAllText("json.txt", json);
            Console.ReadKey();
        }
    }
}
