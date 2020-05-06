using System;
//6)Dados 6 números reales, informar el promedio de los mismos.
namespace Ejercicio6
{
    class Ej6
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            double N1 = 0, N2 = 0, N3 = 0, N4 = 0, N5 = 0, N6 = 0;

            //Pedimos que ingrese los datos
            Console.WriteLine("ingrese el primer numero");
            N1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese el segundo numero");
            N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercero numero");
            N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto numero");
            N4 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el quinto numero");
            N5 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el sexto numero");
            N6 = double.Parse(Console.ReadLine());

            //Mostramos resultados
            Console.WriteLine($"El Promedio de los numeros es: {(N1 + N2 + N3 + N4 + N5 + N6) / 6}");
        }
    }
}
