using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim
{
    public static class GerarGrid
    {
        public static string CriarTerreno(string coordenadaMaxX, string coordenadaMaxY, string grid)
        {
            int posicaoX = default;
            int posicaoY = default;

            while (!int.TryParse(coordenadaMaxX, out posicaoX) || (!int.TryParse(coordenadaMaxY, out posicaoY)))
            {
                Console.Write("Valores inválidos, tente novamente: ");
                grid = Console.ReadLine();

                coordenadaMaxX = grid[0].ToString();
                coordenadaMaxY = grid[2].ToString();
            }
            string gridFinal = String.Concat(new int[] { posicaoX, posicaoY });

            return gridFinal;
        }
    }
}
