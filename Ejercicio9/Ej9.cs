using System;
/* 9)En un curso de ciencias de la computación la calificación final del estudiante se determina a partir del
    rendimiento en tres aspectos del trabajo. A) Existe una calificación por los exámenes parciales que representa el  
    30% del valor total de la nota final. B) la calificación por los trabajos prácticos corresponde al 20% del valor de la 
    nota final.  C) el examen integrador que corresponde al 50% restante.  (los valores de las notas pueden ir de 0 a 10)*/
namespace Ejercicio9
{
    class Ej9
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            double Nparcial = 0, Ntp = 0, Nexamen = 0, Ntotal = 0;

            //Ingresamos datos
            Console.WriteLine("Ingrese nota de parcial");
            Nparcial = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota de trabajo practico");
            Ntp = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota de examen integrador");
            Nexamen = double.Parse(Console.ReadLine());

            //calculamos nota final
            Ntotal = ((Nparcial * 20)/100) + ((Ntp * 30)/100) + ((Nexamen * 50)/100);

            //Mostramos resultado
            Console.WriteLine($"La nota final es: {Ntotal}");
        }
    }
}
