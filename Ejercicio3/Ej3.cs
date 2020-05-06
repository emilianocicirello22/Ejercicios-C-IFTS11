using System;
//3)Dado 1 número con decimales, que representa el lado de un cuadrado se pide informar la superficie del mismo.
namespace Ejercicio3
{
    class Ej3
    {
        static void Main(string[] args)
        {
            //Inicializamos Variables 
            float lado = 0;

            //Pedimos que ingrese los datos
            Console.WriteLine("Ingrese valor de un lado del cuadrado en centimetros");
            lado = float.Parse(Console.ReadLine());

            //mostramos resultado
            Console.WriteLine($"La suoerficie es: {Math.Pow(2,lado)}");

        }
    }
}
