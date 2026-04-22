using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu de operaciones ===");
            Console.WriteLine("1. Calcular area de un circulo");
            Console.WriteLine("2. Calcular area de un cuadrado");
            Console.WriteLine("3. Calcular area de un triangulo");
            Console.WriteLine("4. Salir");

            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Hola, Bienvenido.");
                    break;
                case 2:
                    Console.WriteLine("Hoy es un gran dia.");
                    break;
                case 3:
                    Console.WriteLine("Hasta luego. ");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida. Ingresa un numero del uno al 4.");
                    break;

            }
    }
}
