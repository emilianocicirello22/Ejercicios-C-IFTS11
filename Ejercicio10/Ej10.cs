using System;
/*10)Una concesionaria de autos paga a su personal, un salario de 5500 pesos por mes, mas una comisión del 200 
    pesos por cada auto vendido y un adicional del 5% del valor del auto vendido. Diseñar un algoritmo para calcular 
    el salario total del vendedor. Conociendo solamente el número de autos vendidos y el valor de venta de la unidad.*/
namespace Ejercicio10
{
    class Ej10
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            double Stotal = 0, ValorV = 0;
            int AutosV = 0;

            //Ingresamos datos
            Console.WriteLine("Ingrese la cantidad de autos vendidos");
            AutosV = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del auto vendido");
            ValorV = double.Parse(Console.ReadLine());

            //Calculamos Sueldo del vendedor
            Stotal = (AutosV * 200) + (((AutosV * ValorV) * 5) / 100) + 5500;

            //Informamos el sueldo total
            Console.WriteLine($"El sueldo total es: ${Stotal}");

        }
    }
}
