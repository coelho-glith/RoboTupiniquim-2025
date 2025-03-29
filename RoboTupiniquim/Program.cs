using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu.ExibirMenu();

            RobosTupiniquins primeiroRobo = new RobosTupiniquins();

            RobosTupiniquins segundoRobo = new RobosTupiniquins();

            int[] tamGrid = GerarGrid.CriarTerreno();

            primeiroRobo.EstabelecerPosicao(tamGrid);

            primeiroRobo.MexerRobo(tamGrid);

            primeiroRobo.ApresentarPosicaoAtual();

            Console.Clear();

            segundoRobo.EstabelecerPosicao(tamGrid);

            segundoRobo.MexerRobo(tamGrid);

            segundoRobo.ApresentarPosicaoAtual();

            if (segundoRobo.PosicaOcupada(primeiroRobo) == true)
            {
                Console.WriteLine("GREAT ERROR: O Robô Bateu no outro Robô, trazer de volta para arrumar.");
            }
        }
    }
}