using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public void Speak()
        {
            Console.WriteLine("El perro ladra.");
        }
        public void Action()
        {
            Console.WriteLine("El perro mueve la cola.");
        }
    }
}
