
namespace ExemploHerancaVeiculo.Entities
{
    class Carro : Veiculo
    {
        public string Tipo { get; set; }
        private double _vlImposto;


        public Carro(string nome, string cor, string fabricante, int ano, char importado, double preco, string tipo imposto)
            : base(nome, cor, fabricante, ano, importado, preco)
        {
            Tipo = tipo;
        }

        public override double CalculaImposto()
        {
            if(Preco < 10000)
            {
                _vlImposto = Preco * 0.1;
            }
            else if(Preco >= 10000 && Preco < 40000)
            {
                _vlImposto = Preco * 0.2;
            }
            else if (Preco >= 40000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.25;
            }
            else
            {
                _vlImposto = Preco * 0.35;
            }
            return _vlImposto;
        }
    }
}
