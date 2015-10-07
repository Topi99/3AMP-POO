using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedios
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos, materias;

            try
            {
                Console.Write("Cuantos almnos son? ");
                alumnos = int.Parse(Console.ReadLine());

                Console.Write("Cuantas materias son? ");
                materias = int.Parse(Console.ReadLine());

                float[,] calificaciones = new float[alumnos, materias + 1];

                Alumnos obj = new Alumnos();
                obj.calculaPromedio(calificaciones, alumnos, materias);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nEl promedio grupal es: {0}", obj.promGrup);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("El numero de aprobados es: {0}\nEl número de reprobados es: {1}", obj.contAprob, obj.contReprob);

            }
            catch(Exception ex)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡"+ex.Message.ToString()+"!");
            }

            Console.ReadKey();
             
        }
    }
}
