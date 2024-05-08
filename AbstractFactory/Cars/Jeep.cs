using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cars
{
    public class Jeep : Car
    {
        public override int speed {  get; set; }
        public Jeep(int Speed) { 
            speed = Speed;
        }
    }
}
