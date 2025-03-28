namespace RoboTupiniquim
{
    public static class GerarGrid
    {
        public static string CriarTerreno()
        {
            Console.Clear();
            Console.WriteLine("Informe o tamanho do grid: ");
            Console.Write("formato (X,Y): ");
            string grid = Console.ReadLine();

            string coordenadaMaxX = grid[0].ToString();
            string coordenadaMaxY = grid[2].ToString();

            int posicaoX = default;
            int posicaoY = default;

            while (!int.TryParse(coordenadaMaxX, out posicaoX) || (!int.TryParse(coordenadaMaxY, out posicaoY)))
            {
                Console.Write("Valores inválidos, tente novamente: ");
                grid = Console.ReadLine();

                coordenadaMaxX = grid[0].ToString();
                coordenadaMaxY = grid[2].ToString();
            }
            string gridfinal = String.Concat(new int[] { posicaoX, posicaoY });

            return gridfinal;
        }
    }
}
