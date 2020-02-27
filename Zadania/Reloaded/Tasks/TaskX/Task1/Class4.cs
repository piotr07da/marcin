using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Examples;

namespace Reloaded.Tasks.TaskX.Task1
{
    public  class Class4
    {
        public void Test()
        {
            // Tutaj przykład z moim funcem
            PiotrFunc<int, string, DateTime, double> del1 = (number, someString, someDate) => .333 * (number + someString.Length + someDate.Year);

            // Tutaj to samo tylko trochę bardziej rozpisane:
            PiotrFunc<int, string, DateTime, double> del2 = (number, someString, someDate) =>
            {
                return .333 * (number + someString.Length + someDate.Year);
            };

            // Da się to samo zapisać też tak (czyli do konstruktora delegatu jest podana labmda (metoda anonimowa) odpowiadająca temu delegatowi):
            var del3 = new PiotrFunc<int, string, DateTime, double>((number, someString, someDate) =>
            {
                return .333 * (number + someString.Length + someDate.Year);
            });

            // No i identycznie się sprawi gotowiec w postaci Func albo Action

            Func<int, int, int> sum = (a, b) => a + b;

            Action<int, string> consoleWriter = (count, str) =>
            {
                for (var i = 0; i < count; ++i)
                {
                    Console.WriteLine(str);
                }
                //Console.ReadKey();
            };

            // No i nie pozostaje nic innego niż sobie te delegaty powywoływać:

            var x1 = del1(10, "Piotr", DateTime.Now);
            var x2 = del2(10, "Piotr", new DateTime(2019, 09, 18));
            var x3 = del3(10, "Piotr", DateTime.Now);
            var s = sum(5, 20);
            consoleWriter(5, "Piotr");

            Func<int, double, double> product = (a, b) => a * b;
            var prod = product(10, 1.1);
            Console.ReadKey();
        }
    }
}
