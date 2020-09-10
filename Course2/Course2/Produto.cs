using System.Globalization;


namespace Course2
{
    class Produto
    {

        private string _nome;
        private double _preco;
        private int _quantidade;

        // Construtor ...
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 10;
        }

        public Produto()
        {

        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;

        }

        public override string ToString()
        {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total R$ "
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
