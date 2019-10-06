using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    // Poniższy kod nie ma jak działać bo nie da się w żaden sposób przekazać wartości parametru wind z metody ChangeWind do środka nieskończonej pętli, która jest w metodzie anonimowej (lambdzie).
    // Możesz tę wartośc przekazać tylko raz podczas wywołania metody StartSnow, ale choćbyś tam nawet przekazał wartośc z prywatnego pola to ta lambda sobie i tak zapamięta tę wartość i nawet jak zmienisz pole
    // to lambda dalej będzie widziała pierwotną wartość.
    public class ParametersExample2_DoesntWork1
    {
        public void Init()
        {
            StartSnow(2);
            ChangeWind(10);
            ChangeWind(20);
            ChangeWind(-5);
        }

        public void ChangeWind(int wind)
        {
            // nie bardzo jest co z tym parametrem zrobić żeby pętla for go dostała
        }

        public async Task StartSnow(int wind)
        {
            Task.Run(() =>
            {
                for(; ; )
                {
                    // tutaj jakiś kod zależny od wiatru
                }
            });
        }
    }

    // Poniżej jest dokładnie to samo co powyżej tylko pętla została wyciągnięta do osobnej metody ale to jest dokładnie to samo:
    public class ParametersExample2_DoesntWork2
    {
        public void Init()
        {
            StartSnow(2);
            ChangeWind(10);
            ChangeWind(20);
            ChangeWind(-5);
        }

        public void ChangeWind(int wind)
        {
            // nie bardzo jest co z tym parametrem zrobić żeby pętla for go dostała
        }

        public async Task StartSnow(int wind)
        {
            Task.Run(() =>
            {
                StartSnowMainLoop(wind);
            });
        }

        private void StartSnowMainLoop(int wind)
        {
            // ta metoda wywoła się przecież wyłącznie jeden raz więc siłą rzeczy będzie pamiętała wartość parametru wind taką jaką dostała za piewszym razem

            for (; ; )
            {
                // tutaj jakiś kod zależny od wiatru
            }
        }
    }

    // Poniższy przykład zadziała pod warunkiem, że coś co chce zmienić wiatr będzie trzymało referencję do tego wiatru - referencję do dokładnie tej samej instancji, która została przekazana do metody StartShow, a tym samym do lambdy wywołanej w Task.Run, a tym samym do metody StartSnowMainLoop
    public class ParametersExample2_Works
    {
        public void Init()
        {
            // Czyli tutaj mamy referencję do wiatru w postaci lokalnej zmiennej wind
            var wind = new Wind();

            StartSnow(wind);

            // A tu poniżej modyfikujemy na obiekcie wind wartość property Strength - jak popatrzysz na implementację to tak na prawdę w klasie Wind jest pole _strength czyli tak właściwie jest to rozwiązanie poprzez prywatne pole, a nie parametr - tylko, że prywatne pole jest nie tyle w klasie głównej co w klasie Wind,
            // ale na jedno wychodzi.
            wind.Stregth = 10;
            wind.Stregth = 20;
            wind.Stregth = -5;
        }

        public async Task StartSnow(Wind wind)
        {
            Task.Run(() =>
            {
                StartSnowMainLoop(wind);
            });
        }

        private void StartSnowMainLoop(Wind wind)
        {
            // ta metoda wywoła się przecież wyłącznie jeden raz więc siłą rzeczy będzie pamiętała wartość parametru wind taką jaką dostała za piewszym razem,
            // ale że tym razem jest to referencja do obiektu klasy Wind, a ten obiekt w środku ma prywatne pole to chociaż referencja się nie zmienia to to prywatne pole może się zmieniać i ta nieskończona pętla to zobaczy.

            for (; ; )
            {
                // tutaj jakiś kod zależny od wiatru
            }
        }

        public class Wind
        {
            private int _strength;
            public int Stregth
            {
                get => _strength;
                set => _strength = value;
            }
        }
    }

    // Poniżej rozwiązanie w oparciu o prywatne pole
    public class FieldsExample2_Works
    {
        private int _wind;

        public void Init()
        {
            _wind = 2; // Wcześniej do metody StartSnow przekazywaliśmy wartość 2 jako parametr wind, a teraz po prostu inicjalizujemy pole _wind = 2;
            StartSnow(); // brak parametru wind przekazanego do metody
            ChangeWind(10);
            ChangeWind(20);
            ChangeWind(-5);
        }

        public void ChangeWind(int wind)
        {
            _wind = wind; // Przypisujemy parametr metody do prywatnego pola. Dzięki temu nieskończona pętla for będzie na bieżąca podczas pętlenia się obserwowała to prywatne pole, a ono się będzie zmieniać w wyniku wywołania metody ChangeWind i wszystko zadziała.
        }

        public async Task StartSnow() // brak parametru wind
        {
            Task.Run(() =>
            {
                StartSnowMainLoop();
            });
        }

        private void StartSnowMainLoop() // brak parametru wind
        {
            for (; ; )
            {
                // tutaj jakiś kod zależny od wiatru (_wind)
            }
        }

    }

    
}
