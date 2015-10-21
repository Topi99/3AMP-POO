using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombillas
{
    class Program
    {
        public static void Ir(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        static void Main(string[] args)
        {
            int[] prod = new int[7];
            int[] defect = new int[7];
            int acum = 0, acumDef= 0;
            float totDefect = 0, acumPor = 0;
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Ir(1, 4); Console.Write("Planta");
                Ir(20, 4); Console.Write("Unidades Producidas");
                Ir(42, 4); Console.Write("Unidades Defectuosas");
                Ir(65, 4); Console.Write("% DEFECTUOSAS");
                for (int i = 0; i < 80; i++) { Ir(i, 5); Console.Write("-"); }
                Ir(1, 6); Console.WriteLine("1.- Hermosillo");
                Ir(1, 7); Console.WriteLine("2.- Guamuchil");
                Ir(1, 8); Console.WriteLine("3.- México");
                Ir(1, 9); Console.WriteLine("4.- Tijuana");
                Ir(1, 10); Console.WriteLine("5.- Culiacán");
                Ir(1, 12); Console.WriteLine("TOTAL ");
                Ir(1, 13); Console.WriteLine("PORCENTAJE TOTAL DEFECTUOSOS ");
                Ir(11, 15); Console.Write("Mensaje: ");

                for (int p = 1; p <= 5; p++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Ir(0, 0); Console.WriteLine("Planta No. {0}\n", p);
                    for (int i = 0; i < 7; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Ir(0, 1); Console.Write("Ingrese la cantidad de bombillas producidas el día {0}       ", i + 1);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Ir(0, 2); Console.Write("Ingrese la cantidad de bombillas defectuosas del día {0}     ", i + 1);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Ir(56, 1); prod[i] = int.Parse(Console.ReadLine());
                        Ir(56, 2); defect[i] = int.Parse(Console.ReadLine());
                    }

                    int defectTot = 0, prodTot = 0;
                    
                    for(int z = 0; z < 7; z++)
                    {
                        defectTot += defect[z];
                        prodTot += prod[z];
                    }

                    Planta plant = new Planta();
                    Ir(30, 6 + p-1); Console.Write(prodTot);
                    Ir(50, 6 + p-1); Console.Write(defectTot);
                    Ir(70, 6 + p - 1); Console.Write(plant.calcPorDef(defectTot, prodTot) + "%");
                    acumPor += plant.calcPorDef(defectTot, prodTot);
                    acum += prodTot;
                    acumDef += defectTot;
                }
                Ir(30, 12); Console.Write(acum);
                Ir(50, 12); Console.Write(acumDef);
                totDefect = acumPor / 5;
                Console.ForegroundColor = ConsoleColor.Red;
                Ir(30, 13); Console.Write(totDefect+"%");
                Ir(20, 15); Console.Write("Fin del programa...");

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Ir(20, 15); Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadKey();
        }
    }

    class Planta
    {
        public float calcPorDef(float defect, float prod)
        {
            float totProd = defect + prod;
            float porcent = (defect / totProd) * 100;
            return porcent;
        }
    }
}