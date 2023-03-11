internal class Program
{
    private static void Main(string[] args)
    {
        int contador = 0;
        char[,] tabuleiro = new char[3, 3];

        tabuleiro[0, 0] = '1';
        tabuleiro[0, 1] = '2';
        tabuleiro[0, 2] = '3';
        tabuleiro[1, 0] = '4';
        tabuleiro[1, 1] = '5';
        tabuleiro[1, 2] = '6';
        tabuleiro[2, 0] = '7';
        tabuleiro[2, 1] = '8';
        tabuleiro[2, 2] = '9';




        void ImprimeJogo()
        {
            Console.WriteLine();
            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    Console.Write(tabuleiro[l, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void PosicaoJogador1()
        {
            Console.WriteLine("Jogador 1, escolha uma posição: ");

            char posicao = char.Parse(Console.ReadLine());

            switch (posicao)
            {
                case '1':
                    tabuleiro[0, 0] = 'X';
                    break;

                case '2':
                    tabuleiro[0, 1] = 'X';
                    break;

                case '3':
                    tabuleiro[0, 2] = 'X';
                    break;

                case '4':
                    tabuleiro[1, 0] = 'X';
                    break;

                case '5':
                    tabuleiro[1, 1] = 'X';
                    break;

                case '6':
                    tabuleiro[1, 2] = 'X';
                    break;

                case '7':
                    tabuleiro[2, 0] = 'X';
                    break;

                case '8':
                    tabuleiro[2, 1] = 'X';
                    break;

                case '9':
                    tabuleiro[2, 2] = 'X';
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    PosicaoJogador1();
                    break;
            }
            VerificaVencedor1();
        }

        void PosicaoJogador2()
        {
            Console.WriteLine("Jogador 2, escolha uma posição: ");

            char posicao = char.Parse(Console.ReadLine());

            switch (posicao)
            {
                case '1':
                    tabuleiro[0, 0] = 'O';
                    break;

                case '2':
                    tabuleiro[0, 1] = 'O';
                    break;

                case '3':
                    tabuleiro[0, 2] = 'O';
                    break;

                case '4':
                    tabuleiro[1, 0] = 'O';
                    break;

                case '5':
                    tabuleiro[1, 1] = 'O';
                    break;

                case '6':
                    tabuleiro[1, 2] = 'O';
                    break;

                case '7':
                    tabuleiro[2, 0] = 'O';
                    break;

                case '8':
                    tabuleiro[2, 1] = 'O';
                    break;

                case '9':
                    tabuleiro[2, 2] = 'O';
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    PosicaoJogador2();
                    break;
            }
            VerificaVencedor2();
        }

        void VerificaVencedor1()
        {
            if (
                ((tabuleiro[0, 0] == 'X') && (tabuleiro[0, 1] == 'X') && (tabuleiro[0, 2] == 'X')) ||
                ((tabuleiro[1, 0] == 'X') && (tabuleiro[1, 1] == 'X') && (tabuleiro[1, 2] == 'X')) ||
                ((tabuleiro[2, 0] == 'X') && (tabuleiro[2, 1] == 'X') && (tabuleiro[2, 2] == 'X')) ||
                ((tabuleiro[0, 0] == 'X') && (tabuleiro[1, 0] == 'X') && (tabuleiro[2, 0] == 'X')) ||
                ((tabuleiro[0, 1] == 'X') && (tabuleiro[1, 1] == 'X') && (tabuleiro[2, 1] == 'X')) ||
                ((tabuleiro[0, 2] == 'X') && (tabuleiro[1, 2] == 'X') && (tabuleiro[2, 2] == 'X')) ||
                ((tabuleiro[0, 0] == 'X') && (tabuleiro[1, 1] == 'X') && (tabuleiro[2, 2] == 'X')) ||
                ((tabuleiro[0, 2] == 'X') && (tabuleiro[1, 1] == 'X') && (tabuleiro[2, 0] == 'X'))
                )

            {
                Console.WriteLine("Jogador 1 ganhou!!!");
                Console.WriteLine("Fim do jogo.");
            }
            else
            {
                contador++;
                if (contador == 9)
                {
                    Console.WriteLine("Deu velha!");
                    FimDoJogo();
                }
                else
                {
                    ImprimeJogo();
                    PosicaoJogador2();
                }

            }
        }

        void VerificaVencedor2()
        {

            if (
            ((tabuleiro[0, 0] == 'O') && (tabuleiro[0, 1] == 'O') && (tabuleiro[0, 2] == 'O')) ||
            ((tabuleiro[1, 0] == 'O') && (tabuleiro[1, 1] == 'O') && (tabuleiro[1, 2] == 'O')) ||
            ((tabuleiro[2, 0] == 'O') && (tabuleiro[2, 1] == 'O') && (tabuleiro[2, 2] == 'O')) ||
            ((tabuleiro[0, 0] == 'O') && (tabuleiro[1, 0] == 'O') && (tabuleiro[2, 0] == 'O')) ||
            ((tabuleiro[0, 1] == 'O') && (tabuleiro[1, 1] == 'O') && (tabuleiro[2, 1] == 'O')) ||
            ((tabuleiro[0, 2] == 'O') && (tabuleiro[1, 2] == 'O') && (tabuleiro[2, 2] == 'O')) ||
            ((tabuleiro[0, 0] == 'O') && (tabuleiro[1, 1] == 'O') && (tabuleiro[2, 2] == 'O')) ||
            ((tabuleiro[0, 2] == 'O') && (tabuleiro[1, 1] == 'O') && (tabuleiro[2, 0] == 'O'))
            )

            {
                Console.WriteLine("Jogador 2 ganhou!!!");
                Console.WriteLine("Fim do jogo.");

            }
            else
            {
                contador++;
                if (contador == 9)
                {
                    Console.WriteLine("Deu velha!");
                    FimDoJogo();
                }
                else
                {
                    ImprimeJogo();
                    PosicaoJogador1();
                }

            }

        }

        void FimDoJogo()
        {
            Console.WriteLine("Fim do jogo.");
        }


        ImprimeJogo();

        PosicaoJogador1();


        Console.ReadLine();
    }
}
