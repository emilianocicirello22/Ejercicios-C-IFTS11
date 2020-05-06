using System;
//2) Dados 2 números enteros, que representan los lados de un rectángulo se pide informar la superficie del mismo.
namespace Ejercicio2
{
    class Ej2
    {
        static void Main(string[] args)
        {
            //Declaramos variables 
            int ladoA = 0, ladoB = 0, sup = 0;

            //Pedimos que ingresen los datos
            Console.WriteLine("Ingrese lado A del rectangulo en centimetros");
           
            ladoA = int.Parse(Console.ReadLine());

            //Pedimos que ingresen los datos
            Console.WriteLine("Ingrese lado B del rectangulo en centimetros");
           
            ladoB = int.Parse(Console.ReadLine());

            //Calculamos superficie
            sup = ladoA * ladoB;

            //mostramos el resultado de la superficie
            Console.WriteLine($"La superficie del rectangulo es: {sup} cm");
        }
    }
}
