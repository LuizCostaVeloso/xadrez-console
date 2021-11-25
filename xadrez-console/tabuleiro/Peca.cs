﻿namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtdMovimentos)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }
    }
}
