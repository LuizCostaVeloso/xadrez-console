namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }

        public Peca retirarPeca(Posicao posicao)
        {
            if (peca(posicao) == null)
            {
                return null;
            }

            Peca aux = peca(posicao);
            aux.posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;
            return aux;
        }
        //(EXISTE PEÇA) verifica se ja existe uma peça no tabuleiro 
        public bool existePeca(Posicao posicao) 
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }

        //metodo (posicaoValida) recebe a posição e verifica se e valido
        public bool posicaoValida(Posicao posicao)//ok
        {
            if (posicao.linha < 0 || posicao.linha >= linhas || posicao.coluna < 0 || posicao.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        // metodo que dispara a mensagem se a posição não for valida
        public void validarPosicao(Posicao posicao)//ok
        {
            if (!posicaoValida(posicao))
                throw new TabuleiroException("Posição inválida!");
        }

        // COLOCAR PEÇA verifica se existe uma peça na posição e se não ele adiciona
        public void colocarPeca(Peca peca, Posicao posicao)//ok
        {
            if (existePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }
    }
}
