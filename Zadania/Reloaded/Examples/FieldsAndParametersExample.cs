using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    // W tym przypadku zmieniana wartość jest przekazywana między metodami przez parametr.
    // Czyli metoda dostaje parametr, wykonuje jakieś obliczenia, a następnie zwraca wynik.
    public class ParametersExample1
    {
        public int ChangeValue(int value)
        {
            value = FirstChange(value);
            value = SecondChange(value);
            value = ThirdChange(value, 20);
            return value;
        }

        private int FirstChange(int value)
        {
            value += value;
            value *= 15;
            return value;
        }

        private int SecondChange(int value)
        {
            value *= value;
            value -= 20;
            value = value * value;
            value--;
            return value;
        }

        private int ThirdChange(int value, int a)
        {
            return value + value * 10 + a;
        }
    }

    // W tym przypadku wartość przekazana do metody ChangeValue zostaje zapisana w ramach klasy do jej prywatnego pola _value.
    // Dzięki temu wszystkie metody widzą to pole i mogą na nim operować. Nie trzeba tej wartości przekazywać przez parametr,
    // ani metody nie muszą nic zwracać bo one modyfikują po prostu to pole _value.
    public class FieldExample1
    {
        private int _value;

        public int ChangeValue(int value)
        {
            _value = value;
            FirstChange();
            SecondChange();
            ThirdChange(20);
            return _value;
        }

        private void FirstChange()
        {
            _value += _value;
            _value *= 15;
        }

        private void SecondChange()
        {
            _value *= _value;
            _value -= 20;
            _value = _value * _value;
            _value--;
        }

        private void ThirdChange(int a)
        {
            _value = _value + _value * 10 + a;
        }
    }

    
}
