﻿
using xadrez_console.tabuleiro;

namespace xadrez_console {
   internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    } 
}
