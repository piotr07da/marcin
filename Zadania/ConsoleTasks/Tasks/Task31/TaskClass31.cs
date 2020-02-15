using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleTasks.Tasks.Task31
{
    public class TaskClass31
    {
        public void Test()
        {
            for (; ; )
            {
                var readDouble = new ConsoleValueReader();
                var triangle = new Triangle();

                var firstSide = readDouble.ReadDouble("Podaj pierwszy bok trójkąta");
                var secondSide = readDouble.ReadDouble("Podaj drugi bok trójkąta");
                var thirdSide = readDouble.ReadDouble("Podaj trzeci bok trójkąta");

                if (triangle.CheckTriangle(firstSide, secondSide, thirdSide))
                {
                    Console.WriteLine($"Wymiary trójkąta : {firstSide} , {secondSide} , {thirdSide} , prawidłowe");
                }
                else
                {
                    Console.WriteLine($"Trójkąt o bokach : {firstSide} , {secondSide} , {thirdSide} , nie istnieje");
                }

                Console.WriteLine("Escape, albo inny klawisz - jeszcze raz");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape) { break; }

            }
        }
    }
}
