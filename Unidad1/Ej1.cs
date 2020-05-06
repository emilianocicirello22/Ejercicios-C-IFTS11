using System;
//1)Leer 4 números enteros, calcular la suma e informar el resultado.
namespace Ejercicio1
{
    class Ej1
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0;

            //Pedimos e ingresamos primer numero
            Console.WriteLine("Ingrese un primer numero");
           
            n1 = int.Parse(Console.ReadLine());

            //Pedimos e ingresamos segundo numero
            Console.WriteLine("Ingrese un segundo numero");

            n2 = int.Parse(Console.ReadLine());

            //Pedimos e ingresamos tercero numero
            Console.WriteLine("Ingrese un tercero numero");

            n3 = int.Parse(Console.ReadLine());

            //Pedimos e ingresamos cuarto numero
            Console.WriteLine("Ingrese un cuarto numero");

            n4 = int.Parse(Console.ReadLine());
            
            //mostramos los numeros ingresados y realizamos la suma
            Console.WriteLine($"La suma de {n1} + {n2} + {n3} + {n4} es: {n1+n2+n3+n4}");
        }
    }
}
