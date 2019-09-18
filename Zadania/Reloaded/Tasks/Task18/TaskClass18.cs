using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class TaskClass18
    {
        public void Test()
        {
            double allCubatureSum = 0;
            List<ICubature> cubatures = new List<ICubature>();

            var cube1 = new Cube(10);
            var cube2 = new Cube(20);

            var sphere1 = new Sphere(10);
            var sphere2 = new Sphere(20);

            var cylinder1 = new Cylinder(10, 10);
            var cylinder2 = new Cylinder(20, 20);

            var cone1 = new Cone(10, 10);
            var cone2 = new Cone(20, 20);

            cubatures.Add(cube1);
            cubatures.Add(cube2);
            cubatures.Add(sphere1);
            cubatures.Add(sphere2);
            cubatures.Add(cylinder1);
            cubatures.Add(cylinder2);
            cubatures.Add(cone1);
            cubatures.Add(cone2);

            foreach (var item in cubatures)
            {
                var temp = item.CalculateCubature(); // [PIOTR] - ta linijka raczej niepotrzebna ;)
                allCubatureSum += item.CalculateCubature();
            }
        }
    }
}
