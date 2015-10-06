using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Numeros_al_azar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroLimite, numero, x;
            Console.Write("Ingrese el numero de numeros que desea encontrar al azar: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero al limite de busqueda: ");
            numeroLimite = int.Parse(Console.ReadLine());
            int[] num = new int[100];
            Random objeto = new Random();
            int i = 0;
            for (i = 1; i <= numero; i++)
            {
                num[i] = objeto.Next(0, numeroLimite);
                Console.WriteLine("Numero " + i + " " + num[i]);
                Console.Beep();
            }
            for (i = 1; i <= numero; i++)
            {
                for (int j = i + 1; j <= numero; j++)
                {
                    if (num[i] < num[j])
                    {
                        x = num[i];
                        num[i] = num[j];
                        num[j] = x;

                    }
                }
                Console.WriteLine(num[i]);
            }


            Console.ReadKey();
        }
    }
}
