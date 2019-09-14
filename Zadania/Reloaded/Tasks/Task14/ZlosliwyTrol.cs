using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task14
{
    public class ZlosliwyTrol
    {
        // ------------------------------------------------------------------------------------------------------------------------------------------------
        // Złośliwy trol odwiedził zadanie 14 i odkrył, że w TaskClass14 jest bardzo podobny kod do kodu z TaskClass13 z metody ReadDoubleFromConsole ;)

        // W przyszłych zdaniach też może pojawić się podobna potrzeba. Żeby kodu nie powielać w każdym zadaniu propozycja jest taka:

        // Bezpośrednio w folderze Tasks dodać klasę o nazwie ConsoleValueReader
        // W tej klasie umieścić metodę ReadDoubleFromConsole tylko zmienić jej nazwę na ReadDouble (bo skoro będzie w klasie ConsoleValueReader to nazwa metody niC:\Users\MarcinB\source\repos\marcin\Zadania\Reloaded\Tasks\Task13\TaskClass13.cse musi już zawierać słowa FromConsole)
        // Zrobić tę metodę publiczną.
        // Skorzystać z tej klasy z tą metodą w zadaniach 13, 14 i potencjalnie kolejnych, w których będzie potrzebne wczytywanie wartości double.
        // np.
        // var cvr = new  ConsoleValueReader();
        // double x = cvr.ReadDouble("Podaj x:");
        // albo krócej:
        // double x = new ConsoleValueReader().ReadDouble("Podaj x:");

        // ------------------------------------------------------------------------------------------------------------------------------------------------
        // Złośliwy trol odpowiada na pytania:
        // Tak, można pobrać PI z większą dokładnościa i tak, można potęgować. Jest taka klasa jak Math
        
        public void MathTest()
        {
            var pi = Math.PI;

            var piDoKwardartu = Math.Pow(pi, 2);

            var sinusPi = Math.Sin(Math.PI);
        }
    }
}
