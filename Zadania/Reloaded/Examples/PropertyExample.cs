namespace Reloaded.Examples
{
    public class PropertyExample
    {
        // --------------------------------------------------------------------------------------------------------
        // SPOSÓB 1. czyli ręcznie napisane backing field (pole, w którym przechowujemy dane property) - w tym przypadku _x

        private int _x;

        public int X
        {
            get { return _x; } // Getter jest niczym innym jak metodą, która nic nie przyjmuje, za to zwraca wartość
            set { _x = value; } // Setter jest niczym innym jak metodą, która przyjmuje wartość i nic nie zwraca

            // ... dosłownie to są metody bo jakbyś sobie podejrzał wygenerowany kod MSIL/IL (intermediate language czyli ten assembler .NETowy)
            // po zbuildowaniu takiego kodu w C# to tam już nie będzie śladu po property - zamiast tego będą dwie metody.
            // No bo property to w rzeczywistości tylko taki tak zwany "syntactic sugar" czyli konstrukcja języka, która trochę ułatwia pisanie kodu.
        }



        // --------------------------------------------------------------------------------------------------------
        // SPOSÓB 2. czyli automatyczne property - w tym przypadku backing field wygeneruje się automatycznie podczas buildowania

        public int Y { get; set; }

        // Takie property kompilacja/buildowanie zamienia na takie pole(backing field) (tutaj kod będzie już w intermediate language(IL/MSIL) czyli po zbuildowaniu):

        //.field private float64 '<Y>k__BackingField'

        //oraz na takie dwie metody(get i set) :

        //.method public hidebysig specialname instance float64 get_Y() cil managed
        //.method public hidebysig specialname instance void set_Y(float64 'value'  ) cil managed

        //czyli backing filed typu int i dwie metody get_Y() i set_Y(float64 'value')



        // --------------------------------------------------------------------------------------------------------
        // SPOSÓB 3. - property, które ma backing field ale ma tylko getter

        private int _z;

        public int Z { get { return _z; } }

        // od wersji 7 csharpa można to zapisać skrótowo tak:

        public int InneZ => _z;



        // --------------------------------------------------------------------------------------------------------
        // SPOSÓB 4. - property, które nie ma backing field - jest po prostu property wyliczającym coś, np. na podstawie jakichś innych pól

        private double _pi = 3.14;
        private double _angleInDegrees = 15;

        public double AngleInRadians
        {
            get
            {
                return 2 * _pi * _angleInDegrees / 360;
            }
        }

        // powyższy zapis jest tak właściwie tożsamy z napisaniem metody:

        public double GetAngleInRadians()
        {
            return 2 * _pi * _angleInDegrees / 360;
        }

        // ################### dlaczego publiczne cechy definiujemy zwykle jako property, a nie jako pole ##################


        //        Podsumowanie tego jest takie, że property to tak właściwie metoda, a nie pole.


        //        Jakie to ma znaczenie?
        //A no takie, że interfejsy nie określają pól - nie da się ich tam określić. Pola to część implementacji więc interfejs będący abstrakcją nie może ich posidać.
        // Interfejs może definiować tylko metody i property (które defacto są metodami) - czyli interfejs określa zachowania:

        //Wyobraź sobie taki interfejs:
        //public interface IPerson
        //        {
        //            int Age { get; }
        //        }
        //        Powyższa abstrakcja mówi o tym, że człowiek ma jakiś wiek.
        //        Ale ten interfejs można zaimplementować na wiele sposobów. Np.

        //// w poniższej klasie polem jest _age;
        ///
        //        public class Person : IPerson
        //        {
        //            private int _age;
        //            public Person(int age)
        //            {
        //                _age = age;
        //            }
        //            public int Age { get { return _age; } }
        //        }

        //        albo:

        //// w poniżeszj klasie polem jest _dateOfBirth

        //        public class Person : IPerson
        //        {
        //            private DateTime _dateOfBirth;
        //            public Person(DateTime dateOfBirth)
        //            {
        //                _dateOfBirth = dateOfBirth;
        //            }
        //            public int Age { get { return (DateTime.Now - _dateOfBirth).TotalDays / 365; } }
        //        }

        //        I dlatego właśnie prywatne cechy powinniśmy dawać jako pola, ale publiczne cechy powinniśmy dawać jako property bo to już od konkretnej implementacji danej abstrakcji zależy jakie będą pola.
    }
}
