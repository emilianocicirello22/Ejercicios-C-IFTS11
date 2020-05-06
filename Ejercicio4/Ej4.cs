using System;
using System.Xml.Schema;
/* 4)Se ingresa 3 números que representan horas, minutos y segundos.
Se pide informar el resultado expresado en segundos.
Determinar qué tipo de valor es el aconsejable para los datos solicitados */
namespace Ejercicio4
{
    class Ej4
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            int hora = 0, minutos = 0, segundos = 0, total = 0;

            //Ingresamos los datos
            Console.WriteLine("Ingrese la hora");
            hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los minutos");
            minutos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los segundos");
            segundos = int.Parse(Console.ReadLine());

            //Calculamos la hora en segundos
            total = segundos + (hora * 3600) + (minutos * 60);

            //Mostramos resultados
            Console.WriteLine($"La hora {hora}:{minutos}:{segundos} espresada en segundos es: {total} segundos");
        }
    }
}
