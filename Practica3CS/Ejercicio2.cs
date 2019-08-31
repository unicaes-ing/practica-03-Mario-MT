using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3CS
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Random Nale = new Random();
            int numGen = Nale.Next(1,100);
            Console.WriteLine("El número genereado es: "+ numGen);
            if (numGen % 2 == 0)
            {
                Console.WriteLine("El número generado es par");
            }
            else
            {
                Console.WriteLine("El número generado es impar");
            }
            Console.ReadKey();
        }
    }
}
