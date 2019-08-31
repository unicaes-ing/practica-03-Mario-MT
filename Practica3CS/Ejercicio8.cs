using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3CS
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            decimal comprT, descuento;
            Console.Write("Ingrese el valor de la compra: $");
            comprT = Convert.ToDecimal(Console.ReadLine());
            Random bolitas = new Random();
            int Bolitagen = bolitas.Next(1, 5);
            switch (Bolitagen)
            {
                case 1:
                    Console.WriteLine("La bolita es blanca no aplica a descuento");
                    break;
                case 2:
                    Console.WriteLine("La bolita es verde, se le aplicará el 15% de descuento");
                    descuento = comprT * 0.15m;
                    Console.WriteLine("Su descuento es: {0}, el total a pagar será: {1}", descuento.ToString("C2"), (comprT - descuento).ToString("C2"));
                    break;
                case 3:
                    Console.WriteLine("La bolita es amarilla, se le aplicará el 18% de descuento");
                    descuento = comprT * 0.18m;
                    Console.WriteLine("Su descuento es: {0}, el total a pagar será: {1}", descuento.ToString("C2"), (comprT - descuento).ToString("C2"));
                    break;
                case 4:
                    Console.WriteLine("La bolita es azul, se le aplicará el 20% de descuento");
                    descuento = comprT * 0.20m;
                    Console.WriteLine("Su descuento es: {0}, el total a pagar será: {1}", descuento.ToString("C2"), (comprT - descuento).ToString("C2"));
                    break;
                case 5:
                    Console.WriteLine("La bolita es roja, se le aplicará el 25% de descuento");
                    descuento = comprT * 0.25m;
                    Console.WriteLine("Su descuento es: {0}, el total a pagar será: {1}", descuento.ToString("C2"), (comprT - descuento).ToString("C2"));
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
