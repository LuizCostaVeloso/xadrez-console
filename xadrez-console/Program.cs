using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posicao posicao = new Posicao(3, 4);
            //Console.WriteLine("Posição: " + posicao);
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro);
                    
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao posicaoOrigem = Tela.lerPosicaoXadrez();
                    Console.Write("Destino: ");
                    Posicao posicaoDestino = Tela.lerPosicaoXadrez();

                    partida.executaMovimento(posicaoOrigem, posicaoDestino);

                }

                Tela.imprimirTabuleiro(partida.tabuleiro);

            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }

            //PosicaoXadrez posicao = new PosicaoXadrez('a', 1);

            //Console.WriteLine(posicao);
            //Console.WriteLine(posicao.toPosicao());


            Console.ReadLine();
        }
    }
}
