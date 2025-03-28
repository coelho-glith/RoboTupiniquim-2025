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

        public void MexerRobo()
        {
            Console.Clear();
            Console.Write("Posição Atual");
            ApresentarPosicaoAtual();
            Console.WriteLine("\n Movimentos: \n");
            Console.WriteLine("D -> Virar 90º para direita");
            Console.WriteLine("E -> Virar 90º para esquerda");
            Console.WriteLine("M -> Move uma posição na direção indicada que o Robô está olhando");

            Console.Write("Insira a string de comando: ");
            string movimentos = Console.ReadLine().ToUpper();

            foreach (var movimento in movimentos)
            {
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
            Console.WriteLine($"{PosicaoX} {PosicaoY} {Direcao}");
            Console.WriteLine();
        }

        public void EstabelecerPosicao(string[] tamGrid)
        {
            string auxilioTamGridX = tamGrid[0];
            string auxilioTamGridY = tamGrid[1];

            int gridX = Convert.ToInt32(auxilioTamGridX);
            int gridY = Convert.ToInt32(auxilioTamGridY);

            int posicaoX = default;
            int posicaoY = default;

            Console.WriteLine("Informe a posição inicial do robõ: ");
            Console.Write("formato (X,Y, (Direção)): ");
            string posicao = Console.ReadLine();
            string auxilioDePosicaoX = posicao[0].ToString();
            string auxilioDePosicaoY = posicao[1].ToString();

            char auxilioDirecao = posicao[4];

            string direcao = auxilioDirecao.ToString().ToUpper();

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
            Direcao = Convert.ToChar(direcao);
        }            
    }
}
