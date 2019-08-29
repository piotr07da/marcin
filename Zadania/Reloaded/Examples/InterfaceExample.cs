using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    public class InterfaceExample
    {
        public void Test()
        {
            int x = 0;
            
            var stworek = new Stworek(2000);
            
            stworek.OdzywSie(new Banan());
        }
    }

    class Stworek
    {
        private int _energia;

        public Stworek()
        {
            _energia = 100;
        }

        public Stworek(int energiaPoczatkowa)
        {
            _energia = energiaPoczatkowa;
        }

        public void OdzywSie(IZywnosc z)
        {
            _energia += z.Kcal();
        }

    }

    public interface IZywnosc
    {
        int Kcal();
    }

    public class Banan : IZywnosc
    {
        public int Kcal()
        {
            return 100;
        }
    }

    public class Kurczak : IZywnosc
    {
        public int Kcal()
        {
            return 500;
        }
    }

}
