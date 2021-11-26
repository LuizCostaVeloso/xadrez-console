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
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(3,5));



                Tela.imprimirTabuleiro(tabuleiro);

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
