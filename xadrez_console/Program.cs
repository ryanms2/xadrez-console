﻿
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console {
   internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    
                    partida.executaMovimento(origem, destino);
                }

                
            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    } 
}
