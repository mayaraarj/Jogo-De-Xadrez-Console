﻿using System;
using Tabuleiro;

namespace Jogo_De_Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Posicao P;

            P = new Posicao(3,4);

            Console.WriteLine("Posição: "+ P);

        }
    }
}