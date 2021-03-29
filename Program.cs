using System;

namespace A133590.Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 29");
            Console.WriteLine("Programa que presenta el primero del mes inmediato anterior a la fecha ingresada.");

            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("La fecha ingresada no es válida.");
                Console.WriteLine("Presione cualquier tecla para continuar..");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Resultado: {fecha.AddDays(-fecha.Day + 1).AddMonths(-1).ToString("dd/MM/yyyy")}");

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
