using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16c
{
    public class FunkcjaLiniowa
    {
        public FunkcjaLiniowa(double a, double b)
        {
            A = a;
            B = b;
        }
        double y;
        double x0;
        public double A { get; set; }
        public double B { get; set; }
        private bool _czyRosnaca;
        public bool CzyRosnaca
        {
            get
            {
                if (A > 0) { _czyRosnaca = true; }
                return _czyRosnaca;
            }
        }
        private bool _czyMalejaca;
        public bool CzyMalejaca
        {
            get
            {
                if (A < 0) { _czyMalejaca = true; }
                return _czyMalejaca;
            }
        }
        private bool _czyStala;
        public bool CzyStala
        {
            get
            {
                if (A == 0) { _czyStala = true; }
                return _czyStala;
            }
        }

        public double ObliczWartosc(double x)
        {
            y = A * x + B;
            return y;
        }
        public double ObliczMiejsceZerowe()
        {
            x0 = -(B / A);
            return x0;
        }
    }
}
