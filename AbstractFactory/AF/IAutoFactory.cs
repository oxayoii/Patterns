using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Cars;

namespace AbstractFactory.AF
{
    public interface IAutoFactory
    {
        Car createCar();
        int calculateTime(int distance);
    }
}
