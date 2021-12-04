using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Tela
    {
        public static void imprimirPartida(PartidaDeXadrez partidaDeXadrez)
        {
            imprimirTabuleiro(partidaDeXadrez.tabuleiro);
            Console.WriteLine();
            imprimirPecasCapturadas(partidaDeXadrez);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partidaDeXadrez.turno);
            if (!partidaDeXadrez.terminada)
            {
                Console.WriteLine("Aguardando jogada: " + partidaDeXadrez.jogadorAtual);
                if (partidaDeXadrez.xeque)
                    Console.WriteLine();
                Console.WriteLine("----- XEQUE! -----");
            }
            else
            {
                Console.WriteLine("----- XEQUEMATE!!! -----");
                Console.WriteLine("Vencedor: " + partidaDeXadrez.jogadorAtual);
            }
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas:");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();

        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach (Peca x in conjunto)
            {
                Console.Write("(" + x + ")");
            }
            Console.Write("]");
        }
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");// imprime a de 8 a 1 a sequencia de linha no tabuleiro
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    imprimirPeca(tabuleiro.peca(i, j));
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        //sobre carga do metodo imprimir que imprime o tabuleiro com as posicoes possiveis
        //de movimentações das peças
        public static void imprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                        Console.BackgroundColor = fundoAlterado;
                    else
                        Console.BackgroundColor = fundoOriginal;


                    imprimirPeca(tabuleiro.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        //Converte a peça branca em preta quando ela for diferente 
        public static void imprimirPeca(Peca peca)//ok
        {
            if (peca == null)
                Console.Write("- ");
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }


        }
    }
}
