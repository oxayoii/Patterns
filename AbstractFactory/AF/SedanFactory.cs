using AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AF
{
    public class SedanFactory : IAutoFactory
    {
        public Car createCar()
        {
            return new Sedan(80);
        }

        public int calculateTime(int distance)
        {
            return distance / 80; 
        }
    }
}
