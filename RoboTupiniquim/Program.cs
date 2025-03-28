using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O--------------------------O");
            Console.WriteLine("      Robôs Tupiniquins     ");
            Console.WriteLine("O--------------------------O");

            RobosTupiniquins primeiroRobo = new RobosTupiniquins();

            string tamGrid = GerarGrid.CriarTerreno();

            primeiroRobo.EstabelecerPosicao(tamGrid);

            primeiroRobo.MexerRobo();

            primeiroRobo.ApresentarPosicaoAtual();
        }
    }
}