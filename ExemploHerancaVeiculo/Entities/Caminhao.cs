
namespace ExemploHerancaVeiculo.Entities
{
    class Caminhao: Veiculo
    {
        public string Tipo { get; set; }
        private double _vlImposto;


        public Caminhao(string nome, string cor, string fabricante, int ano, char importado, double preco, string tipo)
            : base(nome, cor, fabricante, ano, importado, preco)
        {
            Tipo = tipo;
        }

        public override double CalculaImposto()
        {
            if (Preco < 30000)
            {
                _vlImposto = Preco * 0.08;
            }
            else if (Preco >= 30000 && Preco < 70000)
            {
                _vlImposto = Preco * 0.15;
            }
            else if (Preco >= 70000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.3;
            }
            else
            {
                _vlImposto = Preco * 0.4;
            }
            return _vlImposto;
        }
    }
}
