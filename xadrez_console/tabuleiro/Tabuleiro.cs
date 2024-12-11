namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.colunas = colunas;
            this.linhas = linhas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna){
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}