using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string coordenadaMaxX = default;
            string coordenadaMaxY = default;
            string grid = default;



            bool prosseguir = false;

            Console.WriteLine("O--------------------------O");
            Console.WriteLine("      Robôs Tupiniquins     ");
            Console.WriteLine("O--------------------------O");

            do
            {
                Console.WriteLine("Coloque os valores que fazerão a base da malha (X Y): ");

                grid = Console.ReadLine()!;
                if (grid[1] != ' ')
                {
                    Console.WriteLine("Utilize apenas espaços para separar os valores");
                    continue;
                }
                else
                {
                    coordenadaMaxX = grid[0].ToString();
                    coordenadaMaxY = grid[2].ToString();
                }

                if (coordenadaMaxX == "0" || coordenadaMaxY == "0")
                {
                    Console.WriteLine("Número(os) nulos, por favor colocar valores acima de 0");
                    continue;
                }
                else
                {
                    prosseguir = true;
                }

            } while (prosseguir == false);
        }
    }
}