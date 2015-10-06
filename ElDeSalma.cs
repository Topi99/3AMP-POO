using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Cuántos números desea obtener");
            a = int.Parse(Console.ReadLine());
            int[] numeros = new int[a];
            Random objeto = new Random();

            for (int i = 0; i < a; i++)
            {
                Console.Write("El número {0} es:  ", +i + 1);
                numeros[i] = objeto.Next(0, 500);
                Console.WriteLine(numeros[i].ToString());
            }

            Array.Sort(numeros);

            Console.WriteLine("\nLos números ordenados son:");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadKey();
        }
    }
}
