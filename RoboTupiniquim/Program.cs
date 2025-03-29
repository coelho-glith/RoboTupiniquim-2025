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
            Console.WriteLine("        Menu Inicial        ");
            Console.WriteLine("O--------------------------O");

            RobosTupiniquins primeiroRobo = new RobosTupiniquins();

            RobosTupiniquins segundoRobo = new RobosTupiniquins();

            string[] tamGrid = GerarGrid.CriarTerreno();

            primeiroRobo.EstabelecerPosicao(tamGrid);

            primeiroRobo.MexerRobo(tamGrid);

            primeiroRobo.ApresentarPosicaoAtual();

            Console.Clear();

            segundoRobo.EstabelecerPosicao(tamGrid);

            segundoRobo.MexerRobo(tamGrid);

            segundoRobo.ApresentarPosicaoAtual();

        }
    }
}