using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3CS
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            TimeSpan hh;
            Console.Write("Ingrese la hora: ");
            hh = TimeSpan.Parse(Console.ReadLine());
            double mm = hh.TotalMinutes;
            double ss = hh.TotalSeconds;
            if (mm > 0 || ss > 0)
            {
                Console.WriteLine("Hora ingresada: "+ hh);
                Console.WriteLine("Equivale a {0} minutos", mm);
                Console.WriteLine("Equivale a {0} segundos", ss);
            }
            else
            {
                Console.WriteLine("Debe de ser un número positivo");
            }
            Console.ReadKey();
        }
    }
}
