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

        public void MexerRobo(int[] tamgrid)
        {
            int gridX = tamgrid[0];
            int gridY = tamgrid[1];

            Console.Clear();
            Console.Write("Posição Atual");
            ApresentarPosicaoAtual();
            Console.WriteLine("Movimentos: ");
            Console.WriteLine("D -> Virar 90º para direita");
            Console.WriteLine("E -> Virar 90º para esquerda");
            Console.WriteLine("M -> Move uma posição na direção indicada que o Robô está olhando");

            Console.Write("Informe uma string de comando: ");
            string movimentos = Console.ReadLine().ToUpper();

            foreach (var movimento in movimentos)
            {
                if (PosicaoX < 0 || PosicaoY < 0 || PosicaoX > gridX || PosicaoY > gridY)
                {
                    Console.WriteLine("O Robô esta fora do Radar!");
                    ForaDoMapa = true;
                    return;
                }

                switch (movimento)
                {
                    case 'E':

                        if (Direcao == 'N')
                            Direcao = 'O';
                        else if (Direcao == 'O')
                            Direcao = 'S';
                        else if (Direcao == 'S')
                            Direcao = 'L';
                        else if (Direcao == 'L')
                            Direcao = 'N';
                        break;

                    case 'D':

                        if (Direcao == 'N')
                            Direcao = 'L';
                        else if (Direcao == 'L')
                            Direcao = 'S';
                        else if (Direcao == 'S')
                            Direcao = 'O';
                        else if (Direcao == 'O')
                            Direcao = 'N';
                        break;

                    case 'M':

                        if (Direcao == 'N')
                            PosicaoY++;
                        else if (Direcao == 'S')
                            PosicaoY--;
                        else if (Direcao == 'L')
                            PosicaoX++;
                        else if (Direcao == 'O')
                            PosicaoX--;

                        break;
                    default:

                        break;
                }
            }
        }

        public void ApresentarPosicaoAtual()
        {
            Console.WriteLine($" {PosicaoX} {PosicaoY} {Direcao}");
            Console.WriteLine();
            Console.ReadLine();
        }

        public void EstabelecerPosicao(int[] tamGrid)
        {
            int auxilioTamGridX = tamGrid[0];
            int auxilioTamGridY = tamGrid[1];

            int posicaoX = default;
            int posicaoY = default;

            Console.WriteLine("Informe a posição inicial do robõ: ");
            Console.Write("formato (X,Y, (Direção)): ");
            string auxilioPosicao = Console.ReadLine();

            string[] posicao = auxilioPosicao.Split(' ', '\t');

            string auxilioDePosicaoX = posicao[0];
            string auxilioDePosicaoY = posicao[1];

            string direcao = posicao[2].ToString().ToUpper();

            while (!int.TryParse(auxilioDePosicaoX, out posicaoX) || (!int.TryParse(auxilioDePosicaoY, out posicaoY)) ||
                 (direcao != "N") && (direcao != "S") && (direcao != "L") && (direcao != "O"))
            {
                Console.Write("Valores inválidos, tente novamente: ");
                auxilioPosicao = Console.ReadLine();

                auxilioDePosicaoX = posicao[0];
                auxilioDePosicaoY = posicao[1];
                direcao = posicao[2].ToString().ToUpper();
            }

            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
            Direcao = Convert.ToChar(direcao);
        }
        public bool PosicaOcupada(RobosTupiniquins robo)
        {
           if (PosicaoX == robo.PosicaoX && PosicaoY == robo.PosicaoY)
                return true;
           else
                return false;
        } 
    }
}
