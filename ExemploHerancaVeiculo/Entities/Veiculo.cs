using ExemploHerancaVeiculo.Entities.Exceptions;
namespace ExemploHerancaVeiculo.Entities

{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public char Importado { get; set; }
        public string Modelo { get; set; }


        public Veiculo(string modelo, string cor, string fabricante, int ano, char importado, double preco)
        {

            if(preco == 0)
            {
                throw new DomainException("Preço incorreto, não é possível lançar preço zerado.");
            }
            Modelo = modelo;
            Cor = cor;
            Fabricante = fabricante;
            Ano = ano;
            Importado = importado;
            Preco = preco;
        }

        public abstract double CalculaPreco();
        public abstract double CalculaImposto();        

    }
}
