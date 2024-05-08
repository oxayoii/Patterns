using AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AF
{
    public class JeepFactory : IAutoFactory
    {
        public Car createCar()
        {
            return new Jeep(100);
        }

        public int calculateTime(int distance)
        {
            return distance / 100; 
        }
    }
}
