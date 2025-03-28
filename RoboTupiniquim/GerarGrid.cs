namespace RoboTupiniquim
{
    public static class GerarGrid
    {
        public static string[] CriarTerreno()
        {
            Console.Clear();
            Console.WriteLine("Informe o tamanho do grid: ");
            Console.Write("formato (X,Y): ");
            string grid = Console.ReadLine();

            string[] posicao = grid.Split(' ', '\t');

            string coordenadaMaxX = posicao[0];
            string coordenadaMaxY = posicao[2];

            int posicaoX = default;
            int posicaoY = default;

            while (!int.TryParse(coordenadaMaxX, out posicaoX) || (!int.TryParse(coordenadaMaxY, out posicaoY)))
            {
                Console.Write("Valores inválidos, tente novamente: ");
                grid = Console.ReadLine();

                posicao = grid.Split(' ', '\t');

                coordenadaMaxX = posicao[0];
                coordenadaMaxY = posicao[2];
            }

            return posicao;
        }
    }
}
