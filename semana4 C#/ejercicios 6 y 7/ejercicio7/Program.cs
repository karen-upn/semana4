using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        // El sistema de notas descarta la práctica más baja de tres y calcula el promedio
        //combinando: examen parcial +examen final + promedio de las 2 mejores prácticas.
        static void Main(string[] args)
        {
            // Entrada de datos
            Console.Write("Ingrese examen parcial: ");
            int parcial = int.Parse(Console.ReadLine());

            Console.Write("Ingrese examen final: ");
            int final = int.Parse(Console.ReadLine());

            Console.Write("Ingrese práctica 1: ");
            int p1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese práctica 2: ");
            int p2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese práctica 3: ");
            int p3 = int.Parse(Console.ReadLine());

            // Uso de Math.Min para encontrar la menor práctica
            int menor = Math.Min(p1, Math.Min(p2, p3));

            // Promedio de las 2 mejores prácticas
            double prom_prac = (p1 + p2 + p3 - menor) / 2.0;

            // Promedio final
            double prom_final = (parcial + final + prom_prac) / 3.0;

            // Mostrar resultados
            Console.WriteLine($"Promedio de prácticas: {prom_prac:F2}");
            Console.WriteLine($"Promedio final: {prom_final:F2}");

            // Clasificación
            if (prom_final >= 18)
            {
                Console.WriteLine("Excelente");
            }
            else if (prom_final >= 14)
            {
                Console.WriteLine("Bueno");
            }
            else if (prom_final >= 10)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Deficiente");
            }
        }
    }
}
