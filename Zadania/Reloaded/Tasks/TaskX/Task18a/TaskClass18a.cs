using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task18a
{
    public class TaskClass18a
    {
        public void Test()
        {
            //double a = 3500;
            //double b, c, d, e, f, g, h, st;
            //b = a / 2;
            //c = b / 2;
            //d = c / 2;
            //e = d / 2;
            //f = e / 2;
            //g = f / 2;
            //h = g / 2;
            //st = a + b + c + d + e + f + g + h;

            double[,] tab = new double[40,2];
            double concentracion = 0;

            /*tab[0] = 3500;
            for (int i = 1; i < 8; i++)
            {
                tab[i] = tab[i - 1] / 2;
            }

            concentracion = CalculateConcentracion(tab);*/


            //for (int i = 0; i < 10; i++)
            //{
            //    a = a / 2;
            //    b = b / 2;
            //    c = c / 2;
            //    d = d / 2;
            //    e = e / 2;
            //    f = f / 2;
            //    g = g / 2;
            //    h = h / 2;
            //    st = a + b + c + d + e + f + g + h;

            //}
            /*for (int a = 0; a < 8; a++)
            {
                for (int i = 0; i < 8; i++)
            {
                tab[i] = tab[i] / 2;
            }
            
                concentracion = CalculateConcentracion(tab);
            }*/

            int shotContr = 2000;
            int shot = 0;            
            tab[0,0] = shotContr;
            //tab[0, 1] = 4;
            int i;

            for (i = 1; i < 300; i++)
            {
                if (i % 4 == 0)
                {
                    shot += 1;
                    tab[shot, 1] = i;
                    tab[shot,0] = shotContr;
                    //concentracion= CalculateConcentracion(tab);
                }

                for (int a = 0; a < 40; a++)
                {

                    if (tab[a , 1] + 6 == i) 
                    {
                        tab[a, 0] = tab[a, 0] / 2;
                        tab[a , 1] += 6;
                        //concentracion = CalculateConcentracion(tab);
                    }
                   
                }
                if (i % 7 == 0)
                {
                    concentracion = CalculateConcentracion(tab);
                }
            }
        }
        private double CalculateConcentracion(double[,] value)
        {
            double concentracion=0;
            for (int b = 0; b < 20; b++)
            {
                concentracion += value[b,0];
            }
            return concentracion;
        }
    }
}
