using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task1
{
    public class Class1
    {
        public void Test()
        {
            StringModiferDelegat del = ModifyString1;
            var string1 = del("Test A");
            Console.WriteLine(string1);

            del = ModifyString2;
            var string2 = del("Test B");
            Console.WriteLine(string2);

            Console.ReadKey();

            del = val =>
            {
                return "*" + val + "*";
            };
            var string3 = del("baran");
            Console.WriteLine(string3);

            Console.ReadKey();
        }

        private string ModifyString1(string value)
        {
            return value.ToUpper();
        }

        private string ModifyString2(string value)
        {
            return value.ToLower();
        }

        public delegate string StringModiferDelegat(string inputString);

    }
}
