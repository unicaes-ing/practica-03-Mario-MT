using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3CS
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, mayor = 0, menor = 0, medio = 0;
            Console.WriteLine("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num2 > num3)
            {
                mayor = num1;
                medio = num2;
                menor = num3;
            }
            else
            {
                if (num1 > num2 && num1 < num3)
                {
                    mayor = num3;
                    medio = num1;
                    menor = num2;
                }
                else
                {
                    if (num1 < num2 && num1 > num3)
                    {
                        mayor = num2;
                        medio = num1;
                        menor = num3;

                    }
                }
            }
            Console.WriteLine("******************");
            Console.WriteLine("Orden ascendente");
            Console.WriteLine("{0}", menor);
            Console.WriteLine("{0}", medio);
            Console.WriteLine("{0}", mayor);
            Console.ReadKey();
        }
    }
}
