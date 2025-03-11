using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Animal
    {
        public virtual void Comer()
        {
            Console.WriteLine("El animal come");
        }

        public void Dormir()
        {
            Console.WriteLine("El animal duerme");
        }
    }
}
