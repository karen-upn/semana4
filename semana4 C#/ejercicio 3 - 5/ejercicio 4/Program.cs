using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese categoría (A/B/C): ");
            string cat = Console.ReadLine().ToUpper();

            Console.Write("Ingrese horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese años de servicio: ");
            int anios = int.Parse(Console.ReadLine());

            double tarifa = 0;

            if (cat == "A") tarifa = 33.50; // categoría A
            else if (cat == "B") tarifa = 29.40; // categoría B
            else if (cat == "C") tarifa = 26.70; // categoría C
            else
            {
                Console.WriteLine("Categoría inválida");
                return; // salir del programa si la categoría no es válida
            }

            double bono = 0;

            if (anios >= 0 && anios <= 3) bono = 0.00;
            else if (anios >= 4 && anios <= 10) bono = 0.10;
            else if (anios >= 11 && anios <= 15) bono = 0.20;
            else bono = 0.30;

            double sueldoFinal = tarifa * horas * (1 + bono);
            Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");
        }
    }
}
