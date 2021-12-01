namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; } 
        public Cor cor { get; protected set; } 
        public int qtdMovimentos { get; protected set; } 
        public Tabuleiro tabuleiro { get; protected set; } 

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tabuleiro = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }
                
        public void incrementarQtdMovimento()
        {
            qtdMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
