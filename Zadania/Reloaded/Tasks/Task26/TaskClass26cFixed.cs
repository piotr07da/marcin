using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task26
{
    class TaskClass26cFixed
    {
        public void Test()
        {
            var numbersA = new int[] { 3, -2, 12, 33, -9, 1, -3, -3, -2, 19, 0, 2 };
            var numbersB = new int[] { 9, 2, 3, -2, 3, -5, -1, 0, -9, 11 };
            var numbersC = new int[] { 1, 2, 3, 9, 3, 4, -8, -2, -5, 1, 99 };


            //var numbersAFilteredList = new List<int>();
            //foreach (var n in numbersA)
            //{
            //    if (n > -2)
            //    {
            //        numbersAFilteredList.Add(n);
            //    }
            //}
            var numberAFilteredMoreThanMinusTwo = FilteredNumber(numbersA, -2);

            //var numbersBFilteredList = new List<int>();
            //foreach (var n in numbersB)
            //{
            //    if (n > 10)
            //    {
            //        numbersBFilteredList.Add(n);
            //    }
            //}
            var numberBFilteredMoreThanTen = FilteredNumber(numbersB, 10);

            //var numbersCFilteredList = new List<int>();
            //foreach (var n in numbersC)
            //{
            //    if (n > -9)
            //    {
            //        numbersCFilteredList.Add(n);
            //    }
            //}
            var numberCFilteredMoreThanMinusNine = FilteredNumber(numbersC, -9);
        }
        private int[] FilteredNumber(int[] numbers, int nMoreThanValue)
        {
            var numbersFilteredList = new List<int>();
            foreach (var n in numbers)
            {
                if (n > nMoreThanValue)
                {
                    numbersFilteredList.Add(n);
                }
            }
            return numbersFilteredList.ToArray();
        }
    }
}
