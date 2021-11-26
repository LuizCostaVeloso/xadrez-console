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
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 9));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tabuleiro);

            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
