using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task21
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime dateOfBirth, Sex sex)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Sex = sex;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        
    }
    public enum Sex
    {
        Male,
        Female,
    }
}
