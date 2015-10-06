using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cachorros
{
    class Program
    {
        static void gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void pintarOpcones()
        {
            Console.WriteLine(" 1.- Tiro a gol \n 2.- Tiro desviado \n 3.- Falta recibida \n 4.- Falta cometida \n 5.- Fuera de Juego");
            Console.WriteLine(" 6.- Tiro de Esquina \n 7.- Amonestacion \n 8.- Gol anotado \n 9.- Gol Recibido \n 10.- Balon Perdido");
            Console.WriteLine(" 11.- Balon Recuperado \n 12.- Pase Corto \n 13.- Pase Equivocado \n 0.- Fin del Juego");
        }

        static void Main(string[] args)
        {

            String equipCont;
            int accion = 1, equipo=0;
            int[,] resultados = new int[12, 2];

            for (int i = 0; i < 12; i++)
            {
                for(int x = 0; x < 2; x++)
                {
                    resultados[i, x] = 0;
                }
            }

            try
            {
                Console.Write("Ingrese nombre del equipo contrario: ");
                equipCont = Console.ReadLine();

                while (accion != 0)
                {

                    pintarOpcones();

                    Console.Write("\nQue ocpion deseas? ");
                    accion = int.Parse(Console.ReadLine());
                    if (accion != 0)
                    {
                        Console.Write("Para que equipo? ");
                        equipo = int.Parse(Console.ReadLine());
                    } 

                    if (equipo == 1 || equipo ==2)
                    {
                        if (accion > 0 && accion <= 13) resultados[accion - 1, equipo - 1]++;
                        else if (accion == 0) accion = 0;
                        else Console.WriteLine("Opcion no valida");

                    }
                    else
                    {
                        Console.Beep();
                        Console.WriteLine("Equipo no válido");
                    }
                    Console.Clear();
                                        
                }
                gotoxy(30, 0); Console.WriteLine("Cachorros");
                gotoxy(43, 0); Console.WriteLine(equipCont);
                gotoxy(0, 1); pintarOpcones();
                for (int i = 0; i < 12; i++) { gotoxy(35, 1 + i); Console.WriteLine(resultados[i,0]); }
                for (int i = 0; i < 12; i++) { gotoxy(45, 1 + i); Console.WriteLine(resultados[i,1]); }
                gotoxy(1, 14); Console.WriteLine("                  ");
                if (resultados[7,0] > resultados[7,1]) Console.WriteLine("Ganaron los Cachorros");
                else if (resultados[7,0] == resultados[7,1]) Console.WriteLine("Empate");
                else Console.WriteLine("Ganaron los " + equipCont);
            }
            catch (FormatException)
            {
                Console.Write("Error");
            }

            Console.ReadKey();
        }
    }
}