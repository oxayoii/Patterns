using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cars
{
    public class Sedan : Car
    {
        public override int speed { get; set; }
        public Sedan(int Speed)
        {
            speed = Speed;
        }
    }
}
