using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3CS
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            decimal MDC, MDV, VP;
            decimal d1 = 0.12m, d2 = 0.15m, d3 = 0.20m;
            Console.WriteLine("Ingrese el monto de la compra");
            Console.Write("$");
            MDC = Convert.ToDecimal(Console.ReadLine());

            if (MDC >0 && MDC <= 100)
            {
                Console.WriteLine("No aplica a desuento");
                Console.WriteLine("El total a pagar por su compra es: {0}", MDC.ToString("C2"));
            }
            else
            {
                if (MDC <= 100.01m && MDC <= 200)
                {
                    Console.WriteLine("Se le aplicara un descuento de 12%");
                    MDV = MDC * d1;
                    VP = MDC - MDV;
                    Console.WriteLine("El descuento a aplicar a su compra es: {0}", MDV.ToString("C2"));
                    Console.WriteLine("EL total a cancelar es: {0}", VP.ToString("C2"));
                }
                else
                {
                    if (MDC <= 200.01m && MDC <= 500)
                    {
                        Console.WriteLine("Se le aplicara un descuento de 15%");
                        MDV = MDC * d2;
                        VP = MDC - MDV;
                        Console.WriteLine("El descuento a aplicar a su compra es: {0}", MDV.ToString("C2"));
                        Console.WriteLine("EL total a cancelar es: {0}", VP.ToString("C2"));
                    }
                    else
                    {
                        if (MDC > 500.01m)
                        {
                            Console.WriteLine("Se le aplicara un descuento de 20%");
                            MDV = MDC * d3;
                            VP = MDC - MDV;
                            Console.WriteLine("El descuento a aplicar a su compra es: {0}", MDV.ToString("C2"));
                            Console.WriteLine("EL total a cancelar es: {0}", VP.ToString("C2"));
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
