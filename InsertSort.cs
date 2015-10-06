using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantNumeros, limite;

            try
            {
                Console.Write("Ingresa la cantidad de números que quieres ordenar: ");
                cantNumeros = int.Parse(Console.ReadLine());

                Console.Write("Ingresa el limite: ");
                limite = int.Parse(Console.ReadLine());

                Random r = new Random();

                int[] numeros = new int[cantNumeros];

                for (int i = 0; i < cantNumeros; i++)
                {
                    numeros[i] = r.Next(0, limite);
                    Console.WriteLine("Numero {0}: {1}", i + 1, numeros[i]);
                }

                Ordenador orden = new Ordenador();
                orden.ordenaInsercion(numeros);

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            catch(Exception ex)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadKey();
        }
    }
    public class Ordenador
    {
        public void ordenaInsercion(int[] array)
        {
            int aux, cont1 = 0, cont2 = 0;
            for(cont1 = 1; cont1 < array.Length; cont1++)
            {
                aux = array[cont1];

                for(cont2 = cont1 - 1;cont2 >= 0 && array[cont2] > aux; cont2--)
                {
                    array[cont2 + 1] = array[cont2];
                    array[cont2] = aux;
                }
            }
        }
    }
}