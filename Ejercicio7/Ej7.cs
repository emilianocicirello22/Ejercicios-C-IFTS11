using System;
/* 7)Dados 2 números enteros, que representan una cantidad parcial y total se pide: Calcular e informar el porcentaje que representa 
   la primera de la segunda. ¿Qué tipo de datos son los recomendados para este algoritmo? */
namespace Ejercicio7
{
    class Ej7
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            int parcial = 0, total = 0;
            double porcentaje = 0;

            //Pedimos datos
            Console.WriteLine("Ingrese cantidad total");
            total = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad parcial");
            parcial = int.Parse(Console.ReadLine());

            //Calculamos el porcentaje
            porcentaje = (parcial * 100) / total;

            //mostramos resultado

            Console.WriteLine($"La cantidad parcial de {parcial} sobre {total} en porcentaje es {porcentaje}%");

        }
    }
}
