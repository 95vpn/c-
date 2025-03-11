using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Perro : Animal
    {
        public void Ladrar()
        {
            Console.WriteLine("El perro ladra");
        }

        public override void Comer()
        {
            Console.WriteLine("El perro come pienso");
        }
    }
}
