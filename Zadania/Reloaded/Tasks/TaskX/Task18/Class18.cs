using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task18
{
    public  class Class18
    {
        public void Test()
        {            
            var cone1 = new Cone(10, 20);
            var cone2 = new Cone(15, 30);
            var cylinder1 = new Cylinder(10, 20);
            var cylinder2 = new Cylinder(15, 39);
            var sphere1 = new Sphere(10);
            var sphere2 = new Sphere(20);
            var cube1 = new Cube(10);
            var cube2 = new Cube(20);

            double coneVolume;
            coneVolume = cone1.CalculateVolume() + cone2.CalculateVolume();

            var cylinderVolume = cylinder1.CalculateVolume() + cylinder2.CalculateVolume();

            var sphereVolume = sphere1.CalculateVolume() + sphere2.CalculateVolume();

            var cubeVolume = cube1.CalculateVolume() + cube2.CalculateVolume();

            List<ICalculateVolumes> list = new List<ICalculateVolumes>();

            list.Add(cone1);
            list.Add(cone2);
            list.Add(cylinder1);
            list.Add(cylinder2);
            list.Add(sphere1);
            list.Add(sphere2);
            list.Add(cube1);
            list.Add(cube2);

            double volumeSum = 0;

            foreach (var item in list)
            {
                volumeSum += item.CalculateVolume();
            }
        }
    }
}
