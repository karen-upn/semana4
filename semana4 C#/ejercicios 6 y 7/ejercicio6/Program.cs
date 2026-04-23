using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        //Dado el promedio de un estudiante (0–20), asigna una calificación. Observa
        //que aquí se usan rangos, no valores exactos.
        static void Main(string[] args)
        {
            int promedio;

            Console.Write("Ingrese el promedio (0-20): ");
            promedio = int.Parse(Console.ReadLine());

            if (promedio >= 0 && promedio <= 5)
            {
                Console.WriteLine("Deficiente");
            }
            else if (promedio >= 6 && promedio <= 10)
            {
                Console.WriteLine("Regular");
            }
            else if (promedio >= 11 && promedio <= 14)
            {
                Console.WriteLine("Bueno");
            }
            else if (promedio >= 15 && promedio <= 20)
            {
                Console.WriteLine("Excelente");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }
}
