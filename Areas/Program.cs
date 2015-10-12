using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, conti = 1;
            float bas, altura, radio, lado;

            try
            {
                while(conti == 1)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("De que figura desea calcular su área? ");
                    Console.WriteLine("\n1.- Triángulo\n2.- Circulo\n3.- Cuadrado\n4.- Rectángulo");

                    Console.SetCursorPosition(39, 0); opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Figura fig = new Figura();

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Cual es la base: ");
                            bas = float.Parse(Console.ReadLine());
                            Console.Write("Cual es el altura: ");
                            altura = float.Parse(Console.ReadLine());
                            Console.WriteLine("El área de tu triángulo es: {0}", fig.CalcAreaTriang(bas, altura));
                            break;
                        case 2:
                            Console.Write("Cuál es el radio: ");
                            radio = float.Parse(Console.ReadLine());
                            Console.WriteLine("El área del circulo es: {0}", fig.CalcCirc(radio));
                            break;
                        case 3:
                            Console.Write("Cual es el lado: ");
                            lado = float.Parse(Console.ReadLine());
                            Console.WriteLine("El área del cuadrado es: {0}", fig.CalcArea(lado));
                            break;
                        case 4:
                            Console.Write("Cual es la base: ");
                            bas = float.Parse(Console.ReadLine());
                            Console.Write("Cual es la altura: ");
                            altura = float.Parse(Console.ReadLine());
                            Console.WriteLine("El área del cuadrado es: {0}", fig.CalcArea(bas, altura));
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Desea hacer otro cálculo? ");
                    conti = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.ResetColor();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fin del programa, presiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}