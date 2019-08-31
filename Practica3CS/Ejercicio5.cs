using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3CS
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int numeros;
            Console.WriteLine("Escriba un número del 1 al 10");
            numeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            if (numeros == 1)
            {
                Console.WriteLine("Uno");
            }
            if (numeros == 2)
            {
                Console.WriteLine("Dos");
            }
            if (numeros == 3)
            {
                Console.WriteLine("Tres");
            }
            if (numeros == 4)
            {
                Console.WriteLine("Cuatro");
            }
            if (numeros == 5)
            {
                Console.WriteLine("Cinco");
            }
            if (numeros == 6)
            {
                Console.WriteLine("Seis");
            }
            if (numeros == 7)
            {
                Console.WriteLine("Siete");
            }
            if (numeros == 8)
            {
                Console.WriteLine("Ocho");
            }
            if (numeros == 9)
            {
                Console.WriteLine("Nueve");
            }
            if (numeros == 10)
            {
                Console.WriteLine("Diez");
            }
            else
            {
                if ( numeros > 10)
                {
                    Console.WriteLine("Número invalido");
                }
            }
            Console.ReadKey();
        }
    }
}
