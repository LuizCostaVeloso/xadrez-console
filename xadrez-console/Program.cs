using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                while (!partidaDeXadrez.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partidaDeXadrez);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao posicaoOrigem = Tela.lerPosicaoXadrez().toPosicao();
                        partidaDeXadrez.validarPosicaoOrigem(posicaoOrigem);

                        bool[,] posicoesPossiveis = partidaDeXadrez.tabuleiro.peca(posicaoOrigem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partidaDeXadrez.tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao posicaoDestino = Tela.lerPosicaoXadrez().toPosicao();
                        partidaDeXadrez.validarPosicaoDeDestino(posicaoOrigem, posicaoDestino);

                        // partidaDeXadrez.executaMovimento(posicaoOrigem, posicaoDestino);
                        partidaDeXadrez.realizaJogada(posicaoOrigem, posicaoDestino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
