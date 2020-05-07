using System;
/* 8)Dada una fecha que se lee en formato numérico DDMMAAAA (dos números para el día, dos para el mes,  cuatro para el año)
     se solicita obtener el día el mes y año por separado en tres variables. (usar descomposición matemática) */
namespace Ejercicio8
{
    class Ej8
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            int fecha = 0, dia = 0, mes = 0, anio = 0;

            //Ingresamos datos
            Console.WriteLine("Ingrese fecha formato DDMMAAAA");
            fecha = int.Parse(Console.ReadLine());

            //Calculamos dia
            dia = fecha / 1000000;

            //Calculamos mes
            mes = (fecha % 1000000) / 10000;

            //Calculamos año
            anio = fecha % 10000;

            //Mostramos fecha completa
            Console.WriteLine($"La fecha es {dia}/{mes}/{anio}");

        }
    }
}
