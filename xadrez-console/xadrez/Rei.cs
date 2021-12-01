using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor):base(tabuleiro, cor)
        { }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao posicao)
        {
            Peca peca = tabuleiro.peca(posicao);
            return peca == null || peca.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            //movimento para cima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            //movimento para cima direita (nordeste)
            pos.definirValores(posicao.linha - 1, posicao.coluna +1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))//ok
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            //movimento para direita 
            pos.definirValores(posicao.linha, posicao.coluna +1); 
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            //movimento para direita abaixo 
            pos.definirValores(posicao.linha + 1, posicao.coluna +1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            //movimento para baixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            //movimento para esquerda abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna -1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            //movimento para esquerda
            pos.definirValores(posicao.linha, posicao.coluna -1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            //movimento para esquerda acima
            pos.definirValores(posicao.linha - 1, posicao.coluna -1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
            }

            return matriz;
        }

    }
}
