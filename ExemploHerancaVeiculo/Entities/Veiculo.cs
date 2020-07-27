namespace ExemploHerancaVeiculo.Entities
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public char Importado { get; set; }
        public string Nome { get; set; }


        public Veiculo(string nome, string cor, string fabricante, int ano, char importado, double preco)
        {
            Nome = nome;
            Cor = cor;
            Fabricante = fabricante;
            Ano = ano;
            Importado = importado;
            Preco = preco;
        }

        public abstract double CalculaImposto();        

    }
}
