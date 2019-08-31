using System;

namespace Practica3CS
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            int origen, destino;
            double Cant, conver;
            Console.WriteLine("Unidades de masa");
            Console.WriteLine("[1] Onzas");
            Console.WriteLine("[2] Libras");
            Console.WriteLine("[3] Gramos");
            Console.WriteLine("[4] Toneladas");
            Console.WriteLine("\n Seleccione la unidad de origen");
            origen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Ingrese una cantidad a convertir");
            Cant = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Seleccione la unidad de destino");
            destino = Convert.ToInt32(Console.ReadLine());
            switch (origen)
            {
                case 1:
                    if (destino == 1)
                    {
                        Console.WriteLine("El origen y destino deben ser diferente");
                    }
                    else
                    {
                        if (destino == 2)
                        {
                            Console.WriteLine("convertirá {0} Onzas a Libras", Cant);
                            conver = Cant * 0.0625;
                            Console.WriteLine("Resultado: {0:N2}", conver);
                        }
                        else
                        {
                            if (destino == 3)
                            {
                                Console.WriteLine("convertirá {0} Onzas a Gramos", Cant);
                                conver = Cant * 28.3495;
                                Console.WriteLine("Resultado: {0:N2}", conver);
                            }
                            else
                            {
                                if (destino == 4)
                                {
                                    Console.WriteLine("convertirá {0} Onzas a Toneladas", Cant);
                                    conver = Cant * 0.00002835;
                                    Console.WriteLine("Resultado: {0:N2}", conver);
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    if (destino == 1)
                    {
                        Console.WriteLine("convertirá {0} Libras a Onzas", Cant);
                        conver = Cant * 16;
                        Console.WriteLine("Resultado: {0:N2}", conver);
                    }
                    else
                    {
                        if (destino == 2)
                        {
                            Console.WriteLine("El origen y destino deben ser diferente");
                        }
                        else
                        {
                            if (destino == 3)
                            {
                                Console.WriteLine("convertirá {0} Libras a Gramos", Cant);
                                conver = Cant * 453.6;
                                Console.WriteLine("Resultado: {0:N2}", conver);
                            }
                            else
                            {
                                if (destino == 4)
                                {
                                    Console.WriteLine("convertirá {0} Libras a Toneladas", Cant);
                                    conver = Cant * 0.0004536;
                                    Console.WriteLine("Resultado: {0:N2}", conver);
                                }
                            }
                        }
                    }
                    break;
                case 3:
                    if (destino == 1)
                    {
                        Console.WriteLine("convertirá {0} Gramos a Onzas", Cant);
                        conver = Cant * 0.035273368606702;
                        Console.WriteLine("Resultado: {0:N2}", conver);
                    }
                    else
                    {
                        if (destino == 2)
                        {
                            Console.WriteLine("convertirá {0} Gramos a Libras", Cant);
                            conver = Cant * 0.0022045855379189;
                            Console.WriteLine("Resultado: {0:N2}", conver);
                        }
                        else
                        {
                            if (destino == 3)
                            {
                                Console.WriteLine("El origen y destino deben ser diferente");
                            }
                            else
                            {
                                if (destino == 4)
                                {
                                    Console.WriteLine("convertirá {0} Toneladas a gramos", Cant);
                                    conver = Cant * 0.000001;
                                    Console.WriteLine("Resultado: {0:N2}", conver);
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    if (destino == 1)
                    {
                        Console.WriteLine("convertirá {0} Tonelada a Onzas", Cant);
                        conver = Cant * 35273.368606702;
                        Console.WriteLine("Resultado: {0:N2}", conver);
                    }
                    else
                    {
                        if (destino == 2)
                        {
                            Console.WriteLine("convertirá {0} Tonelada a Libras", Cant);
                            conver = Cant * 2204.5855379189;
                            Console.WriteLine("Resultado: {0:N2}", conver);
                        }
                        else
                        {
                            if (destino == 3)
                            {
                                Console.WriteLine("convertirá {0} Toneladas a Gramos", Cant);
                                conver = Cant * 1000000;
                                Console.WriteLine("Resultado: {0:N2}", conver);
                            }
                            else
                            {
                                if (destino == 4)
                                {
                                    Console.WriteLine("El origen y destino deben ser diferente");
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
