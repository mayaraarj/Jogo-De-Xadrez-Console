﻿using System;
using tabuleiro;

namespace Jogo_De_Xadrez_Console.xadrez
{
    //Vamos usar Dama no lugar de Rainha pra que a inicial não se confunda com a inicial do Rei
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "D";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }


            //direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            // acima 
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            // abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //Noroeste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);

            }

            //Nordeste
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //Sudeste
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            {
                while (tab.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    {
                        break;
                    }
                    pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
                }

            }

            //Sudoeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            {
                while (tab.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    {
                        break;
                    }
                    pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
                }
            }

            return mat;
        }
    }
}
