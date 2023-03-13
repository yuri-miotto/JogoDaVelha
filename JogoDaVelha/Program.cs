internal class Program
{
    private static void Main(string[] args)
    {
        int contador = 0;
        char[,] tabuleiro = new char[3, 3];
        int posicao1 = 0;
        int posicao2 = 0;
        int posicao3 = 0;
        int posicao4 = 0;
        int posicao5 = 0;
        int posicao6 = 0;
        int posicao7 = 0;
        int posicao8 = 0;
        int posicao9 = 0;

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
                    if(posicao1 == 0)
                    {
                        tabuleiro[0, 0] = 'X';
                        posicao1++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '2':
                    if(posicao2 == 0)
                    {
                        tabuleiro[0, 1] = 'X';
                        posicao2++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '3':
                    if(posicao3 == 0)
                    {
                        tabuleiro[0, 2] = 'X';
                        posicao3++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '4':
                    if(posicao4 == 0)
                    {
                        tabuleiro[1, 0] = 'X';
                        posicao4++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '5':
                    if(posicao5 == 0)
                    {
                        tabuleiro[1, 1] = 'X';
                        posicao5++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '6':
                    if(posicao6 == 0)
                    {
                        tabuleiro[1, 2] = 'X';
                        posicao6++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '7':
                    if(posicao7 == 0)
                    {
                        tabuleiro[2, 0] = 'X';
                        posicao7++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '8':
                    if(posicao8 == 0)
                    {
                        tabuleiro[2, 1] = 'X';
                        posicao8++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    case '9':
                    if(posicao9 == 0)
                    {
                        tabuleiro[2, 2] = 'X';
                        posicao9++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador1();
                    }
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine();
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
                    if (posicao1 == 0)
                    {
                        tabuleiro[0, 0] = 'O';
                        posicao1++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '2':
                    if (posicao2 == 0)
                    {
                        tabuleiro[0, 1] = 'O';
                        posicao2++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '3':
                    if (posicao3 == 0)
                    {
                        tabuleiro[0, 2] = 'O';
                        posicao3++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '4':
                    if (posicao4 == 0)
                    {
                        tabuleiro[1, 0] = 'O';
                        posicao4++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '5':
                    if (posicao5 == 0)
                    {
                        tabuleiro[1, 1] = 'O';
                        posicao5++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '6':
                    if (posicao6 == 0)
                    {
                        tabuleiro[1, 2] = 'O';
                        posicao6++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '7':
                    if (posicao7 == 0)
                    {
                        tabuleiro[2, 0] = 'O';
                        posicao7++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '8':
                    if (posicao8 == 0)
                    {
                        tabuleiro[2, 1] = 'O';
                        posicao8++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                case '9':
                    if (posicao9 == 0)
                    {
                        tabuleiro[2, 2] = 'O';
                        posicao9++;
                    }
                    else
                    {
                        Console.WriteLine("Essa posição já foi escolhida!");
                        Console.WriteLine();
                        PosicaoJogador2();
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine();
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
                Console.WriteLine();
                FimDoJogo();
            }
            else
            {
                contador++;
                if (contador == 9)
                {
                    Console.WriteLine("Deu velha!");
                    Console.WriteLine();
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
                Console.WriteLine();
                FimDoJogo();

            }
            else
            {
                contador++;
                if (contador == 9)
                {
                    Console.WriteLine("Deu velha!");
                    Console.WriteLine();
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
