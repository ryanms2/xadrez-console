
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console {
   internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 0));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    } 
}
