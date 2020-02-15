using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTasks.Examples
{
    public class Szklanka
    {
        private readonly double _pojemnosc;
        private double _zawartosc;

        public Szklanka(double pojemnosc)
        {
            _pojemnosc = pojemnosc;
        }

        public double Pojemnosc
        {
            get
            {
                return _pojemnosc;
            }
        }

        public void Dolej(double ilosc)
        {
            _zawartosc += ilosc;
            if (_zawartosc > _pojemnosc)
            {
                _zawartosc = _pojemnosc;
            }
        }
    }

    public class SzklankaTesty : ITask
    {
        public void Test()
        {
            var s1 = new Szklanka(250);
            var s2 = new Szklanka(300);
            var s3 = new Szklanka(350);
            Szklanka s4 = null;

            s1.Dolej(240);
            s1.Dolej(35);


            var p3 = s3.Pojemnosc;
            var p4 = s4.Pojemnosc;
        }
    }
}
