using System;
/*5)Se  necesita calcular la superficie de un triángulo, y se dispone solamente de los valores de su base y altura. 
    Definir también que tipo de valor es aconsejable para las variables con la información que se tiene.
    **No se podrá usar valores fijos en las fórmulas del algoritmo. Solo variables y/o constantes.** */
namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables y constantes
            double baseT = 0;
            double altura = 0;
            const int divisor = 2;

            //Pedimos datos
            Console.WriteLine("Ingrese base del triangulo en centimetros");
            baseT = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura del triangulo en centimetros");
            altura = double.Parse(Console.ReadLine());


            //Mostramos resultados
            Console.WriteLine($"La superficie del triangulo es: {(baseT * altura) / divisor} cm");
        }
    }
}
