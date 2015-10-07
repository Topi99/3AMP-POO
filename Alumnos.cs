using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedios
{
    class Alumnos
    {
        public string nombre;
        public float aux = 0, aux2 = 0, promGrup;
        public int x = 0, contAprob = 0, contReprob = 0;

        public void calculaPromedio(float[,] array, int alumnos, int materias)
        {
            for (int i = 0; i < alumnos; i++)
            {
                Console.Write("\nCual es el nombre del alumno {0} ", i + 1);
                this.nombre = Console.ReadLine();

                for (x = 0; x < materias; x++)
                {
                    Console.Write("Cual es la calificacion {0} ", x + 1);
                    array[i, x] = float.Parse(Console.ReadLine());
                    aux = aux + array[i, x];
                }

                for (int y = 0; y < materias; y++)
                {
                    array[i, materias] = (aux / x);
                }
                Console.WriteLine("El promedio del alumno {0} es: {1}", i + 1, array[i, materias]);
                aux = 0;
            }

            for (int i = 0; i < alumnos; i++)
            {
                aux2 = aux2 + array[i, materias];
            }

            promGrup = aux2 / alumnos;

            for (int i = 0; i < alumnos; i++)
            {
                if (array[i, materias] >= 6) contAprob++;
                else contReprob++;
            }
        }
    }
}
