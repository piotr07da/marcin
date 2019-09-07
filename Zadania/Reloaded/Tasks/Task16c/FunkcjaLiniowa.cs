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
      
        public double A { get; set; }
        public double B { get; set; }
       
        public bool CzyRosnaca
        {
            get
            {
                return A > 0;
            }
        }
       
        public bool CzyMalejaca
        {
            get
            {
                return A < 0;
            }
        }
       
        public bool CzyStala
        {
            get
            {
                return A == 0;
            }
        }

        public double ObliczWartosc(double x)
        {
            return A * x + B;
        }
        public double ObliczMiejsceZerowe()
        {
            return -(A / B);
        }
    }
}
