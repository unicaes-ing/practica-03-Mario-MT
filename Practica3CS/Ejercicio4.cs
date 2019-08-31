using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3CS
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int min;
            decimal costo = 0, zona, zonaOc = 0.32m, zonaC = 0.25m, zonaOr = 0.36m;
            Console.Write("Ingrese el total de minutos hablados: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seleccione la zona a la que se realizo la llamada");
            Console.WriteLine("1- Zona Occidental");
            Console.WriteLine("2- Zona Central");
            Console.WriteLine("3- Zona Oriental");
            Console.Write("zona ");
            zona = Convert.ToInt32(Console.ReadLine());
            switch (zona)
            {
                case 1:
                    costo = min * zonaOc;
                    break;
                case 2:
                    costo = min * zonaC;
                    break;
                case 3:
                    costo = min * zonaOr;
                    break;
                default:
                    Console.WriteLine("Número de zona invalido");
                    break;
            }
            Console.WriteLine("El total a cancalar por la llamada es: {0}", costo.ToString("C2"));
            Console.ReadKey();

        }
    }
}
