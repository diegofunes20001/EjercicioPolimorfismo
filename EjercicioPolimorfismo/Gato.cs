using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public void Speak()
        {
            Console.WriteLine("El gato Maúlla.");
        }
        public void Action()
        {
            Console.WriteLine("El gato ronronea.");
        }
    }
}
