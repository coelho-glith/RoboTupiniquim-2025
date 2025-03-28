namespace RoboTupiniquim
{
    public class RobosTupiniquins
    {
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public char Direcao { get; set; }

        public bool ForaDoMapa { get; set; }

        public RobosTupiniquins()
        {
            PosicaoX = 0;

            PosicaoY = 0;

            Direcao = 'N';

            ForaDoMapa = false;
        }

        public void ApresentarPosicaoAtual()
        {
            Console.WriteLine($"{PosicaoX} {PosicaoY} {Direcao} \n");
        }

        public void EstabelecerPosicao(string tamGrid)
        {
            string auxilioTamGridX = tamGrid[0].ToString();
            string auxilioTamGridY = tamGrid[1].ToString();

            int gridX = Convert.ToInt32(auxilioTamGridX);
            int gridY = Convert.ToInt32(auxilioTamGridY);

            int posicaoX = default;
            int posicaoY = default;

            Console.WriteLine("Informe a posição inicial do robõ: ");
            Console.Write("formato (X,Y): ");
            string posicao = Console.ReadLine();
            string auxilioDePosicaoX = posicao[0].ToString();
            string auxilioDePosicaoY = posicao[2].ToString();

            while (!int.TryParse(auxilioDePosicaoX, out posicaoX) || (!int.TryParse(auxilioDePosicaoY, out posicaoY)))
            {
            ForaDaArea:
                Console.Write("Valores inválidos, tente novamente: ");
                posicao = Console.ReadLine();

                auxilioDePosicaoX = posicao[0].ToString();
                auxilioDePosicaoY = posicao[2].ToString();
            }

            PosicaoX = posicaoX;
            PosicaoY = posicaoY;

        }
    }
}
